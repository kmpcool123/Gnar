using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Data.Entities
{
    public class Completes
    {
        [Required]
        public Guid OwnerId { get; set; }
        [Key]
        public int CompleteId { get; set; }

        [Required]
        [Display(Name = "Complete Name")]
        public string CompleteName { get; set; }

        public virtual ICollection<Deck> Decks { get; set; }
        public virtual ICollection<Bearings> Bearings { get; set; }
        public virtual ICollection<GripTape> GripTapes { get; set; }
        public virtual ICollection<HardWare> HardWares { get; set; }
        public virtual ICollection<Trucks> Trucks { get; set; }
        public virtual ICollection<Wheels> Wheels { get; set; }
    }
}
