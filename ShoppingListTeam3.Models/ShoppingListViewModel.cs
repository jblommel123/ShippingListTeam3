using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListTeam3.Models
{
    public class ShoppingListViewModel
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public string Group { get; set; }

        [Display (Name = "Created Date")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified Date")]
        public DateTimeOffset ModifieddUtc { get; set; }
    }
}
