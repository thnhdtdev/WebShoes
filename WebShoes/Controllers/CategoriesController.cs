using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShoes.Models;

namespace WebShoes.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            Database2Entities db = new Database2Entities();
            List<Category> categories= db.Categories.ToList();
            return View(categories);
        }
    }
}