using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShoes.Models;

namespace WebShoes.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Database2Entities db = new Database2Entities();
            List<Product> products = db.Products.ToList();
            return View(products);
        }
    }
}