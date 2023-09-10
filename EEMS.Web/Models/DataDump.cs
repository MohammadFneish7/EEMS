using System.ComponentModel.DataAnnotations;

namespace EEMS.Web.Models
{
    public class DataDump
    {
        [Required]
        public int Year { get; set; }

        [Required]
        public int Month { get; set; }
    }
}
