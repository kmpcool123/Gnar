using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.WheelsModel
{
    public class WheelsListItem
    {
        public int WheelsId { get; set; }


        [Display(Name = "Wheel Name")]
        public string WheelsName { get; set; }

        

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
