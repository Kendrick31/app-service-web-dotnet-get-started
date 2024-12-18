using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

public IActionResult Index()
{
    throw new Exception("This is a test exception");
}

namespace aspnet_get_started
{
    public IActionResult Index()
    {
        throw new Exception("This is a test exception");
    }
    public class MvcApplication : System.Web.HttpApplication
    {
        public IActionResult Index()
        {
            throw new Exception("This is a test exception");
        }
        protected void Application_Start()
        {
            public IActionResult Index()
            {
                throw new Exception("This is a test exception");
            }
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Index()
        }
    }
}
