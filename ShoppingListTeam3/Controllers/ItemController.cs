using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShoppingListTeam3.Data;
using ShoppingListTeam3.Models;
using ShoppingListTeam3.Services;

namespace ShoppingListTeam3.Controllers
{
    public class ItemController : Controller
    {
        private readonly Lazy<ItemService> _svc = new Lazy<ItemService>();

        // GET: Item
        public ActionResult Index(int? id)
        {
            {
                var Item = _svc.Value.GetItemsByShoppingListID(id.Value);
                return View(Item);
            }
        }

        //// GET: Item/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ItemViewModel itemViewModel = db.ItemViewModels.Find(id);
        //    if (itemViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(itemViewModel);
        //}

        //// GET: Item/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Item/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,Content,Priority,IsChecked,CreatedUtc,ModifiedUtc")] ItemViewModel itemViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.ItemViewModels.Add(itemViewModel);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(itemViewModel);
        //}

        //// GET: Item/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ItemViewModel itemViewModel = db.ItemViewModels.Find(id);
        //    if (itemViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(itemViewModel);
        //}

        //// POST: Item/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Content,Priority,IsChecked,CreatedUtc,ModifiedUtc")] ItemViewModel itemViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(itemViewModel).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(itemViewModel);
        //}

        //// GET: Item/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ItemViewModel itemViewModel = db.ItemViewModels.Find(id);
        //    if (itemViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(itemViewModel);
        //}

        //// POST: Item/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    ItemViewModel itemViewModel = db.ItemViewModels.Find(id);
        //    db.ItemViewModels.Remove(itemViewModel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //}
    }
}
