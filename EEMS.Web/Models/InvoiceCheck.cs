using System.ComponentModel.DataAnnotations;

namespace EEMS.Web.Models
{
    public class InvoiceCheck
    {
        [Required]
        public string? Group { get; set; }

        [Required]
        public string? CustId { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Month { get; set; }
    }
}
