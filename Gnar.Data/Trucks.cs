using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Data
{
    public class Trucks
    {
        [Key]
        public int TruckId { get; set; }

        [Required]
        public string TruckName { get; set; }

        public decimal Size { get; set; }

        public string ProModel { get; set; }

        public decimal Weight { get; set; }

        public string Color { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
