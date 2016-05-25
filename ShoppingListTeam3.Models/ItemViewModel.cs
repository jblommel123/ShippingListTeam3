using ShoppingListTeam3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListTeam3.Models
{
    public class ItemViewModel
    {
        [Key]
        public int ID { get; set; }
        public int ShoppingListID { get; set; }
        public int NoteID { get; set; }
        public string Content { get; set; }
        public int Priority { get; set; }
        [Display(Name = "")]
        public bool IsChecked { get; set; }
        [Display(Name = "Created Date")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Modified Date")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
