using EEMS.Web.ATS.Objects;
using EEMS.Web.ATS.Repositories;
using EEMS.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO.Compression;
using System.Reflection;
using System.Text;

namespace EEMS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ATSRepository<Invoice> _aTSRepository;

        public HomeController(ILogger<HomeController> logger, 
            IConfiguration configuration,
            ATSRepository<Invoice> aTSRepository)
        {
            _logger = logger;
            _configuration = configuration;
            _aTSRepository = aTSRepository;
        }

        [AllowAnonymous]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "api.writer")]
        [Route("/UploadData")]
        public IActionResult UploadData()
        {
            return View();
        }

        [Authorize(Roles = "api.writer")]
        [HttpPost]
        [Route("/UploadData")]
        public async Task<IActionResult> UploadData([Bind("File")] FileUpload fileUpload)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(fileUpload.File?.FileName);
                    var contentType = fileUpload.File?.ContentType;
                    using (var stream = new MemoryStream())
                    {
                        await fileUpload.File?.CopyToAsync(stream);

                        var txt = Encoding.UTF8.GetString(Decompress(stream.GetBuffer()));
                        var invoices = JsonConvert.DeserializeObject<List<Invoice>>(txt);
                        foreach (var inv in invoices)
                        {
                            inv.PartitionKey = User?.Identity?.Name?.Split("@")[0];
                        }
                        var invgroups = invoices.Select((x, i) => new { Index = i, Value = x }).GroupBy(x => x.Index / 100).Select(x => x.Select(v => v.Value).ToList()).ToList();
                        foreach(var group in invgroups)
                        {
                            var result = await _aTSRepository.UpsertManyAsync(group);
                            if (result.Any(r => !(r.HttpStatusCode >= 200) && (r.HttpStatusCode <= 299)))
                            {
                                throw new IOException("فشل أثناء محاولة كتابة البيانات.");
                            }
                        }
                        ViewData["data"] = "تمت العمليّة بنجاح.";
                    }
                }
                else
                {
                    throw new IOException("الرجاء التأكد من تعبئة المعلومات المطلوبة.");
                }

            }
            catch (Exception ex)
            {
                if(ex.GetType() == typeof(IOException))
                    ViewData["error"] = ex.Message;
                else
                    ViewData["error"] = "فشل أثناء قراءة الملف، الرجاء التأكد من صحّة الملف.";
            }
            return View();
        }

        [AllowAnonymous]
        [Route("/Check")]
        public IActionResult Check(string group="", string clientid = "")
        {
            ViewData["group"] = group;
            ViewData["clientid"] = clientid;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/Check")]
        public async Task<IActionResult> Check([Bind("Group,ClientId,Year,Month")] InvoiceCheck invoiceCheck)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var invoice = await _aTSRepository.SingleAsync(invoiceCheck.Group.ToLower(), $"{invoiceCheck.ClientId}-{invoiceCheck.Year}-{invoiceCheck.Month}".ToLower());
                    if (invoice == null)
                        throw new Exception("الفاتورة المطلوبة غير موجودة");
                    else
                        ViewData["data"] = invoice.Data;
                }
                else
                {
                    throw new Exception("الرجاء التأكد من تعبئة المعلومات المطلوبة");
                }
            }
            catch (Exception ex)
            {
                ViewData["error"] = ex.Message;
            }
            ViewData["group"] = invoiceCheck.Group;
            ViewData["clientid"] = invoiceCheck.ClientId;
            return View(invoiceCheck);
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static byte[] Decompress(byte[] data)
        {
            MemoryStream input = new MemoryStream(data);
            MemoryStream output = new MemoryStream();
            using (DeflateStream dstream = new DeflateStream(input, CompressionMode.Decompress))
            {
                dstream.CopyTo(output);
            }
            return output.ToArray();
        }
    }
}