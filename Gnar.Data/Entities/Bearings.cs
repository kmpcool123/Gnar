using System;
using System.Collections.Generic;
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
        [MinLength (1)]
        [MaxLength(100)]
        [Display(Name = "Bearing Name")]
        public string BearingName { get; set; }

        [Display(Name = "Brand Name")]
        [MaxLength(100)]
        public string BrandName { get; set; }

        [Display(Name = "Abec Rating")]
        public int AbecRating { get; set; }
        public int Type { get; set; }

        [Display(Name = "Pro-Model")]
        
        [MaxLength(100)]
        public int ProModel { get; set; }
        public string Color { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
