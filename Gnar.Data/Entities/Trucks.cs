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
        [Required]
        public Guid OwnerId { get; set; }
        [Key]
        public int TruckId { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        [Display(Name = "Truck Name")]
        public string TruckName { get; set; }

        public decimal Size { get; set; }

        
        [MaxLength(100)] 
        [Display(Name ="Pro-Model")]
        public string ProModel { get; set; }

        public decimal Weight { get; set; }

        public string Color { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
