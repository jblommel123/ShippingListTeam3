using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListTeam3.Models
{
    public class ItemWithNoteViewModel
    {
        public IEnumerable<ItemViewModel> Items { get; set; }

        public NoteViewModel Note { get; set; }
    }
}
