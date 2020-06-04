using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.HardWaresModel
{
    public class HardWareListItem
    {
        public int HardWareId { get; set; }


        [Display(Name = "HardWare Name")]
        public string HardWareName { get; set; }

        

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
