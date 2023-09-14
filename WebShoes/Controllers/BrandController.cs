using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShoes.Models;

namespace WebShoes.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        public ActionResult Index()
        {
            Database2Entities db = new Database2Entities();
            List<Brand> brands = db.Brands.ToList();
            return View(brands);
        }
    }
}