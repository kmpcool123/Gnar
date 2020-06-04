using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.TrucksModel
{
    public class TrucksListItem
    {
        public int TrucksId { get; set; }


        [Display(Name = "Trucks Name")]
        public string TrucksName { get; set; }

        

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
