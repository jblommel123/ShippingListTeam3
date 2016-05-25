using ShoppingListTeam3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListTeam3.Models;

namespace ShoppingListTeam3.Services
{
    public class ItemService
    {
        public IEnumerable<ItemViewModel> GetItemsByShoppingListID(int? id)
        {
            using (var ctx = new ShoppingListDbContext())
            {
                string query = "SELECT * FROM Item WHERE ShoppingListID = @p0";
                return ctx.Items.SqlQuery(query, id).Select(
                    e => new ItemViewModel { ID = e.ID, Content = e.Content, IsChecked = e.IsChecked, CreatedUtc = e.CreatedUtc, ModifiedUtc = e.ModifiedUtc }
                ).ToArray();
            }
        }

        //public ShoppingListViewModel GetListByID(int? id)
        //{
        //    ShoppingList entity;

        //    using (var ctx = new ShoppingListDbContext())
        //    {
        //        entity = ctx.ShoppingLists.SingleOrDefault(e => e.ID == id);
        //    }
        //    if (entity != null)
        //        return new ShoppingListViewModel
        //        {
        //            ID = entity.ID,
        //            Name = entity.Name,
        //            Group = entity.Group,
        //            Color = entity.Color,
        //            CreatedUtc = entity.CreatedUtc,
        //            ModifieddUtc = entity.ModifieddUtc
        //        };
        //    else
        //        return null;
        //}

        //public bool CreateList(ShoppingListViewModel vm)
        //{
        //    using (var ctx = new ShoppingListDbContext())
        //    {
        //        var entity =
        //            new ShoppingList
        //            {
        //                UserID = _userID,
        //                Name = vm.Name,
        //                Color = vm.Color,
        //                Group = vm.Group,
        //                CreatedUtc = DateTimeOffset.Now,
        //            };

        //        ctx.ShoppingLists.Add(entity);

        //        return ctx.SaveChanges() == 1;
        //    }
        //}

        //public bool UpdateList(ShoppingListViewModel vm)
        //{
        //    using (var ctx = new ShoppingListDbContext())
        //    {
        //        var entity = ctx.ShoppingLists.SingleOrDefault(e => e.ID == vm.ID);

        //        entity.Name = vm.Name;
        //        entity.Color = vm.Color;
        //        entity.Group = vm.Group;
        //        entity.ModifieddUtc = DateTimeOffset.Now;

        //        return ctx.SaveChanges() == 1;
        //    }
        //}

        //public bool DeleteList(int? id)
        //{
        //    using (var ctx = new ShoppingListDbContext())
        //    {
        //        //ctx.Database.ExecuteSqlCommand($"DELETE FROM Review WHERE ProductID = {id}");

        //        var entity = ctx.ShoppingLists.SingleOrDefault(e => e.ID == id);

        //        // TODO: Handle note not found
        //        ctx.ShoppingLists.Remove(entity);

        //        return ctx.SaveChanges() == 1;
        //    }
        //}
    }
}
