using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IBFree.Models;

namespace IBFree.Controllers
{
    public class TeatController : Controller
    {
        private IBFreeContext db = new IBFreeContext();

        // GET: Teat
        public ActionResult Index()
        {
            return View(db.BadFoods.ToList());
        }

        // GET: Teat/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadFood badFood = db.BadFoods.Find(id);
            if (badFood == null)
            {
                return HttpNotFound();
            }
            return View(badFood);
        }

        // GET: Teat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Fructan,Sorbitol,Mannitol,Fructose,GOS,Lactose,FoodChallenge,Image")] BadFood badFood)
        {
            if (ModelState.IsValid)
            {
                db.BadFoods.Add(badFood);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(badFood);
        }

        // GET: Teat/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadFood badFood = db.BadFoods.Find(id);
            if (badFood == null)
            {
                return HttpNotFound();
            }
            return View(badFood);
        }

        // POST: Teat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Fructan,Sorbitol,Mannitol,Fructose,GOS,Lactose,FoodChallenge,Image")] BadFood badFood)
        {
            if (ModelState.IsValid)
            {
                db.Entry(badFood).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(badFood);
        }

        // GET: Teat/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadFood badFood = db.BadFoods.Find(id);
            if (badFood == null)
            {
                return HttpNotFound();
            }
            return View(badFood);
        }

        // POST: Teat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BadFood badFood = db.BadFoods.Find(id);
            db.BadFoods.Remove(badFood);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
