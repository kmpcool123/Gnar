using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.WheelsModel
{
    public class WheelsDetail
    {
        
        
        public int WheelId { get; set; }

        

        [Display(Name = "Wheel Name")]
        public string WheelName { get; set; }

        public decimal Size { get; set; }


        [Display(Name = "Pro-Model")]
        public string ProModel { get; set; }


        public string Brand { get; set; }

        public int Softness { get; set; }

        public string Type { get; set; }

        public string Color { get; set; }


        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
