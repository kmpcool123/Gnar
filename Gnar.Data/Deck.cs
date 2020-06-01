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
        [Key]
        public int DeckId{ get;set;}
        [Required]
        public string DeckName { get; set; }
        public string Brand { get; set; }
        public decimal Size { get; set; }
        public string ProModel { get; set; }
        public string Shape { get; set; }
        public decimal WheelBase { get; set; }
        public string Color { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
