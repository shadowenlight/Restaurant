using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using Restaurant.Models;
using System.Collections.Generic;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private FoodDB db = new FoodDB();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Menu()
        {
            var categories = db.Categories;
            return View(categories.ToList());
        }

        public ActionResult FoodSearch (string f)
        {
            var foods = db.Foods.Include(a=>a.Category).Where(a=>a.Name.Contains(f)).Take(10).ToList();
            return View(foods);
        }

        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FoodId, CategoryId, FoodArtUrl, Price, Name")] Food food)
        {
            if (ModelState.IsValid)
            {
                db.Foods.Add(food);
                db.SaveChanges();
                return RedirectToAction("Menu");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name", food.CategoryId);
            return View();
        }

        public ActionResult Preview(int? id)
        {
            var food = db.Foods.Find(id);
            return View(food);
        }
    }
}