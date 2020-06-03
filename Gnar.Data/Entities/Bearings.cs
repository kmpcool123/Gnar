using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Data
{
    public class Bearings
    {
        [Required]
        public Guid OwnerId { get; set; }
        [Key]
        public int BearingId { get; set; }
        
        [Required]
        [Display(Name = "Bearing Name")]
        public string BearingName { get; set; }

        
        public string Brand { get; set; }

        [Display(Name = "Abec Rating")]
        public int AbecRating { get; set; }
        public int Type { get; set; }

        [Display(Name = "Pro-Model")]
        
        public string ProModel { get; set; }

        public string Color { get; set; }

        [DefaultValue(false)]
        public bool IsStarred { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
