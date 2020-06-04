using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.GriptapesModel
{
    public class GripTapeCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "At least 2 characters.")]
        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        [Display(Name = "GripTape Name")]
        public string GripTapeName { get; set; }

        
        public decimal Width { get; set; }

        
        public decimal Length { get; set; }

        [Display(Name = "Pro-Model")]
        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string ProModel { get; set; }

        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string Color { get; set; }

        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string Brand { get; set; }


        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
