using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.BearingsModel
{
    public class BearingsListItem
    {
        public int BearingId { get; set; }


        [Display(Name = "Bearings Name")]
        public string BearingName { get; set; }

        [UIHint("Starred")]
        public bool IsStarred { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
