using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShoes.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AllProduct()
        {
            return View();
        }
        public ActionResult Male() 
        {
            return View();
        }
        public ActionResult Female() 
        {
            return View();
        }
        public ActionResult Kid() 
        {
            return View();
        }

    }
}