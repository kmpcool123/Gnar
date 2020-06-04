using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.CompletesModel
{
    public class CompletesCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "At least 2 characters.")]
        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        [Display(Name = "Complete Name")]
        public string CompleteName { get; set; }
    }
}
