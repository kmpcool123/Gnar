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
        [Key]
        public int BearingId { get; set; }
        [Required]
        public string BearingName { get; set; }
        public string BrandName { get; set; }
        public int AbecRating { get; set; }
        public int Type { get; set; }
        public int ProModel { get; set; }
        public string Color { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
