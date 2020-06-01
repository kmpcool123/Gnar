using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Data
{
    public class HardWare
    {
        [Key]
        public int HardWareId { get; set; }

        [Required]
        public string HardWareName { get; set; }

        [Required]
        public decimal Size { get; set; }

        public string Color { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
