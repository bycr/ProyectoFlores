using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyectoflores.Controllers
{
    public class HomeController : Controller
    {
        public static string vistaindex()
        {
            return "view";
        }
        public static string vistaabout()
        {
            return "view";
        }
        public static string vistacontact()
        {
            return "view";
        }
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
    }
}