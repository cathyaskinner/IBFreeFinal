using IBFree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;




namespace IBFree.Controllers
{
    public class HomeController : Controller
    {
        private IBFreeContext db = new IBFreeContext();
        List<SelectListItem> food = new List<SelectListItem>();

        public ActionResult Search(string searchTerm = null)
        {
            var model = db.BadFoods.Where(r => r.Name.StartsWith(searchTerm))
                .Select(r => new BAdFoodListViewModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    FoodChallenge = r.FoodChallenge,
                    Fructan = r.Fructan,
                    Fructose = r.Fructose,
                    GOS = r.GOS,
                    Image = r.Image,
                    Lactose = r.Lactose,
                    Mannitol = r.Mannitol,
                    Sorbitol = r.Sorbitol
                });
            return View(model);
        }

    
        [HttpPost]
        public ActionResult Search()
        {
            if (Request.Form["mychallenge"] != null)
            {
                return View("Challenge");
            }
            else 
            {
                return View("Search");
            }

        }

        //About
        public ActionResult About()
        {
           
            return View();
        }

        //Challenge Page views
        public ActionResult Challenge()
        {    
            Random rnd = new Random();         
            var foods = db.BadFoods.Where(x => x.FoodChallenge == true).ToList();
            var lenght = db.BadFoods.Where(x => x.FoodChallenge == true).Count();  
            int index = rnd.Next(lenght);              

            //TempData
            BadFood f1 = foods[index];

            string f18 = null;

            if (f1.Sorbitol == true)
            {
                f18 = "Sorbitol";
            }
            else if (f1.Fructan == true)
            {
                f18 = "Fructan";
            }
            else if (f1.Fructose == true)
            {
                f18 = "Fructose";
            }
            else if (f1.Mannitol == true)
            {
                f18 = "Mannitol";
            }
            else if (f1.Lactose == true)
            {
                f18 = "Lactose";
            }
            else if (f1.GOS == true)
            {
                f18 = "GOS";
            }

            var challe = f1.Name;
            TempData["BadieBoo"] = f18;
            TempData["foodie"] = challe;

            return View(f1);
                 
        }

        [HttpPost]
        public ActionResult Challenge(BadFood f1)
        {
            if (Request.Form["Chall"] != null)   //changed
            {
                return RedirectToAction("Day1");
            }
            return View();

        }


        [HttpGet]
        public ActionResult Day1()
        {
            string f1 = TempData["foodie"].ToString();
            string fIT = TempData["BadieBoo"].ToString();

            TempData["forNextOne"] = f1;
            TempData["NextIrritant"] = fIT;

            ViewBag.Boo = fIT;
            ViewBag.bla = f1;
            return View();
        }

       
        [HttpPost]
        public ActionResult Day1(BigViewModel u)
        {
            if (Request.Form["NoSymptoms"] != null)   //changed
            {
                return RedirectToAction("Day2", u);
            }
            if (Request.Form["Symptoms"] != null)
            {
                return RedirectToAction("Create", u);
            }
            return View();
        } 
   
         [HttpGet]
         public ActionResult Day2()
         {
             string f1 = TempData["forNextOne"].ToString();
             string fIT = TempData["NextIrritant"].ToString();

             TempData["forNextOne"] = f1;
             TempData["NextIrritant"] = fIT;

             ViewBag.Boo = fIT;
             ViewBag.bla = f1;

             return View();       
         }
         [HttpPost]
         public ActionResult Day2(BigViewModel u)
         {
             if (Request.Form["NoSymptoms"] != null)
             {
                 return RedirectToAction("Day3", u);
             }
             if (Request.Form["Symptoms"] != null)
             {
                 return RedirectToAction("Create", u);
             }
             return View();
         }


         [HttpGet]
         public ActionResult Day3()
         {
             string f1 = TempData["forNextOne"].ToString();
             string fIT = TempData["NextIrritant"].ToString();

             TempData["forNextOne"] = f1;
             TempData["NextIrritant"] = fIT;

             ViewBag.Boo = fIT;
             ViewBag.bla = f1;
             return View();
         }

        [HttpPost]
        public ActionResult Day3(BigViewModel u)
         {
             if (Request.Form["NoSymptoms"] != null)
             {
                 return RedirectToAction("Party", u);
             }
             if (Request.Form["Symptoms"] != null)
             {
                 return RedirectToAction("Create", u);
             }
             return View();
         }

        public ActionResult Party()
        {
            string f1 = TempData["forNextOne"].ToString();
            TempData["forNextOne"] = f1;
          
            ViewBag.bla = f1;
            return View();
        }
        [HttpPost]
        public ActionResult Party(BigViewModel u)
        {

            return View(u);
        }
         public ActionResult BadFoodList()
         {
             var foods = db.BadFoods.ToList();

             return View(foods);
         }



         
       
        //public ActionResult Index(string badFoodNames) 
        //{
        //    var NameLst = new List<string>();

        //    var NameQry = from d in db.BadFoods
        //                  orderby d.Name
        //                  select d.Name;

        //    NameLst.AddRange(NameQry.Distinct());
        //    ViewBag.badFoodNames = new SelectList(NameLst);

        //    var foods = from m in db.BadFoods
        //                select m;


        //    if (!string.IsNullOrEmpty(badFoodNames))
        //    {
        //        foods = foods.Where(x => x.Name == badFoodNames);
        //    }

        //    return View(foods);
        //}

        

    }
}


     

