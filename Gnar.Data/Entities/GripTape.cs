using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Data
{
    public class GripTape
    {
        [Required]
        public Guid OwnerId { get; set; }
        [Key]
        public int GripTapeId { get; set; }
        
        [Required]
        
        [Display (Name ="GripTape Name")]
        public string GripTapeName { get; set; }
        
        [Required]
        public decimal Width { get; set; }
        
        [Required]
        public decimal Length { get; set; }

        [Display(Name ="Pro-Model")]
        public string ProModel { get; set; }
        
        public string Color { get; set; }

        
        public string Brand { get; set; }

        [DefaultValue(false)]
        public bool IsStarred { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
