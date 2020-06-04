using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.BearingsModel
{
    public class BearingsDetail
    {
        public int BearingId { get; set; }

        
        [Display(Name = "Bearing Name")]
        public string BearingName { get; set; }


        public string Brand { get; set; }

        [Display(Name = "Abec Rating")]
        public int AbecRating { get; set; }
        public int Type { get; set; }

        [Display(Name = "Pro-Model")]

        public string ProModel { get; set; }

        public string Color { get; set; }



        [Display(Name = "Made")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Changed")]
        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
