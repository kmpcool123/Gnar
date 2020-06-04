using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models
{
    public class DeckListItem
    {
        public int DeckId { get; set; }


        [Display (Name = "Deck Name")]
        public string DeckName { get; set; }

        [UIHint("Starred")]
        public bool IsStarred { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
