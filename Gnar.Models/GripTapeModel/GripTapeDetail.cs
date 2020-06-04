using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.GriptapesModel
{
    public class GripTapeDetail
    {
        public int GripTapeId { get; set; }

        [Display(Name = "GripTape Name")]
        public string GripTapeName { get; set; }

        
        public decimal Width { get; set; }

        
        public decimal Length { get; set; }

        [Display(Name = "Pro-Model")]
        public string ProModel { get; set; }

        public string Color { get; set; }


        public string Brand { get; set; }



        [Display(Name = "Made")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Changed")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
