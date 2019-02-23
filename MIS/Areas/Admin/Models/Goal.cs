using System.ComponentModel.DataAnnotations;

namespace MIS.Areas.Admin.Models
{
    public class Goal
    {
        [Required]
        [Display(Name ="Goal Name")]
        public string Name { get; set; }

    }
}