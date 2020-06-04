using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models
{
    public class DeckDetails
    {
        
        [Display(Name ="Deck Name")]
        public string DeckName { get; set; }

        
        public string Brand { get; set; }

        public decimal Size { get; set; }

        [Display(Name ="Pro-Model")]
        public string ProModel { get; set; }

        
        public string Shape { get; set; }

        [Display(Name="Wheel Base")]
        public decimal WheelBase { get; set; }

        
        public string Color { get; set; }

        [Display(Name = "Made")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Changed")]
        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
