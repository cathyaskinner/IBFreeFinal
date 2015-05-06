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
    public class BigViewModels1Controller : Controller
    {
        private IBFreeContext db = new IBFreeContext();

        // GET: BigViewModels1
        public ActionResult MyResults()
        {
            return View(db.BigViewDb.ToList());
        }

        // GET: BigViewModels1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BigViewModel bigViewModel = db.BigViewDb.Find(id);
            if (bigViewModel == null)
            {
                return HttpNotFound();
            }
            return View(bigViewModel);
        }

        // GET: BigViewModels1/Create
        public ActionResult Create(string badFoodNames)
        {
            string f1 = TempData["forNextOne"].ToString();
            string fIT = TempData["NextIrritant"].ToString();
            
            TempData["NextIrritant"] = fIT;
            TempData["forNextOne"] = f1;

            ViewBag.Boo = fIT;
            ViewBag.bla = f1;

            return View();
        }

        // POST: BigViewModels1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ImputId,FoodName,Iritance,Symptoms,Severity")] BigViewModel bigViewModel)
        {
           // IBFreeContext db = new IBFreeContext();

            if (ModelState.IsValid)
            {
                using(var db = new IBFreeContext())
                {
                    string f1 = TempData["forNextOne"].ToString();

                    string f18 = TempData["NextIrritant"].ToString();

                    BigViewModel b1 = new BigViewModel();
                    b1.FoodName = f1;
                    b1.Iritance = f18;
                    b1.Symptoms = bigViewModel.Symptoms;
                    b1.Severity = bigViewModel.Severity;
                    db.BigViewDb.Add(b1);
                    db.SaveChanges();

                }
                return RedirectToAction("MyResults");
            }

            return View(bigViewModel);
        }

        // GET: BigViewModels1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BigViewModel bigViewModel = db.BigViewDb.Find(id);
            if (bigViewModel == null)
            {
                return HttpNotFound();
            }
            return View(bigViewModel);
        }

        // POST: BigViewModels1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ImputId,Severity")] BigViewModel bigViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bigViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("MyResults");
            }
            return View(bigViewModel);
        }

        // GET: BigViewModels1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BigViewModel bigViewModel = db.BigViewDb.Find(id);
            if (bigViewModel == null)
            {
                return HttpNotFound();
            }
            return View(bigViewModel);
        }

        // POST: BigViewModels1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BigViewModel bigViewModel = db.BigViewDb.Find(id);
            db.BigViewDb.Remove(bigViewModel);
            db.SaveChanges();
            return RedirectToAction("MyResults");
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
