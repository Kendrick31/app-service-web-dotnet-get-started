using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_get_started.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {    
            throw new Exception("This is a test exception");
            return View();
        }

        public ActionResult About()
        {
            throw new Exception("This is a test exception");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public void IActionResult Index()
        {
            throw new Exception("This is a test exception");
        }

        public ActionResult Contact()
        {
            throw new Exception("This is a test exception");
            ViewBag.Message = "Your contact page.";

            return View();
        }    
    }
}
