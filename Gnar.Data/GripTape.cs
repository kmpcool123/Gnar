using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Data
{
    public class GripTape
    {
        [Key]
        public int GripTapeId { get; set; }
        
        [Required]
        public string GripTapeName { get; set; }
        
        [Required]
        public decimal Width { get; set; }
        
        [Required]
        public decimal Length { get; set; }
        
        public string ProModel { get; set; }
        
        public string Color { get; set; }

        public string Brand { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
