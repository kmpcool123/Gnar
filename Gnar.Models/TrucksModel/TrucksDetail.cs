using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.TrucksModel
{
    public class TrucksDetail
    {
        public int TruckId { get; set; }

        
        [Display(Name = "Truck Name")]
        public string TruckName { get; set; }

        public decimal Size { get; set; }


        public string Brand { get; set; }



        [Display(Name = "Pro-Model")]
        public string ProModel { get; set; }

        public decimal Weight { get; set; }

        public string Color { get; set; }


        [Display(Name = "Made")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Changed")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
