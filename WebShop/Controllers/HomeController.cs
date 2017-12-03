using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Heading = "Welcome to Webshop";
            ViewBag.Subheading = "The Best Real Estate Website in Toronto";
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

        public ActionResult Properties()
        {
            ViewBag.Heading = "Properties";
            ViewBag.Subheading = "More than billion properties listed";
            return View();
        }
    }
}