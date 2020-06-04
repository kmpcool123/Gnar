using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.GriptapesModel
{
    public class GripTapeListItem
    {
        public int GripTapeId { get; set; }


        [Display(Name = "GripTape Name")]
        public string GripTapeName { get; set; }
        

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
