using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.WheelsModel
{
    public class WheelsEdit
    {
        public int WheelId { get; set; }

        [Display(Name = "Wheel Name")]
        
        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string WheelName { get; set; }

        public decimal Size { get; set; }


        [Display(Name = "Pro-Model")]
        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string ProModel { get; set; }


        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string Brand { get; set; }

        public int Softness { get; set; }


        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string Type { get; set; }


        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string Color { get; set; }



        [Display(Name = "Edited")]
        

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
