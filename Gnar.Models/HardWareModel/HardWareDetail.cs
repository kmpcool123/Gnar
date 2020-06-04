using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.HardWaresModel
{
    public class HardwareDetail
    {
        public int HardWareId { get; set; }

        [Display(Name = "HardWare Name")]
        public string HardWareName { get; set; }

        [Display(Name = "Pro-Model")]
        public string ProModel { get; set; }


        public string Brand { get; set; }


        public decimal Size { get; set; }

        public string Color { get; set; }


        [Display(Name = "Made")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Changed")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
