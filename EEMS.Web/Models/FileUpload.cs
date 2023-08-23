using System.ComponentModel.DataAnnotations;

namespace EEMS.Web.Models
{
    public class FileUpload
    {
        [Required]
        public IFormFile? File { set; get; }
    }
}
