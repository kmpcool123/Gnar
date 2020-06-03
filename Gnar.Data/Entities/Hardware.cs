using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Data
{
    public class HardWare
    {
        [Required]
        public Guid OwnerId { get; set; }
        [Key]
        public int HardWareId { get; set; }

        [Required]
        [Display(Name = "HardWare Name")]
        public string HardWareName { get; set; }

        [Display(Name ="Pro-Model")]
        public string ProModel { get; set; }

        
        public string Brand { get; set; }

        
        public decimal Size { get; set; }

        public string Color { get; set; }
        
        [DefaultValue(false)]
        public bool IsStarred { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
