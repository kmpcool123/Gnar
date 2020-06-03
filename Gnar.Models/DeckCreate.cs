using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models
{
    public class DeckCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "At least 2 characters.")]
        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]

        public string DeckName { get; set; }

        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string Brand { get; set; }

        public decimal Size { get; set; }

        [Display(Name = "Pro-Model")]
        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string ProModel { get; set; }

        [MaxLength(50, ErrorMessage = "Woah there, too many characters.")]
        public string Shape { get; set; }

        [Display(Name = "Wheel Base")]
        public decimal WheelBase { get; set; }

        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string Color { get; set; }

        

        

    }
}
