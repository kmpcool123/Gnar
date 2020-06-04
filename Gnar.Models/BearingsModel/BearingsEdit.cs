using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.BearingsModel
{
    public class BearingsEdit
    {
        public int BearingId { get; set; }

        [MinLength(2, ErrorMessage = "At least 2 characters.")]
        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        [Display(Name = "Bearings Name")]
        public string BearingName { get; set; }


        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string Brand { get; set; }

        [Display(Name = "Abec Rating")]
        public int AbecRating { get; set; }
        public int Type { get; set; }

        [Display(Name = "Pro-Model")]

        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string ProModel { get; set; }


        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string Color { get; set; }



        [Display(Name ="Edited.")]

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
