using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_get_started.Controllers
{
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        if (id == 0)
        {
            throw new Exception("Invalid Id");
        }
        return "value";
    }
    public class HomeController : Controller
    {
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
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            throw new Exception("Invalid Id");
            return "1";
        }
        throw new Exception("This is a general exception.");
    
    
    }
}
