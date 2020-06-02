using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Data
{
    public class Deck
    {
        [Required]
        public Guid OwnerId { get; set; }
        
        [Key]
        public int DeckId{ get;set;}

        [Required]
        [Display(Name = "Deck Name")]
        [MinLength(1)]
        [MaxLength(100)]
        public string DeckName { get; set; }

        [MaxLength(100)]
        public string Brand { get; set; }
        
        public decimal Size { get; set; }

        [Display(Name = "Pro-Model")]
        [MaxLength(100)]
        public string ProModel { get; set; }

        [MaxLength(100)]
        public string Shape { get; set; }

        [Display(Name = "Wheel Base")]        
        public decimal WheelBase { get; set; }

        public string Color { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
