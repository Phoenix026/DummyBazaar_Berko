using DummyBazaarBerko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DummyBazaarBerko.Areas.AdminPanel.Controllers
{
    public class CategoryController : Controller
    {
        DummyBazaarModel db = new DummyBazaarModel();
        // GET: AdminPanel/Category
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add (model); 
                db.SaveChanges();  
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}