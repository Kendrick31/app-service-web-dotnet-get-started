using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;



namespace aspnet_get_started
{

    public class Global : HttpApplication
    {
       public static log4net.ILog logger;
    
       void Application_Start(object sender, EventArgs e)
       {
           // Code that runs on application startup
           RouteConfig.RegisterRoutes(RouteTable.Routes);
           BundleConfig.RegisterBundles(BundleTable.Bundles);
    
           // Setup Application Insights
           TelemetryConfiguration config = TelemetryConfiguration.Active;
           TelemetryConfiguration.Active.ConnectionString = "InstrumentationKey=8ad68a6f-fb39-430f-9eda-ec54a5567706;IngestionEndpoint=https://southeastasia-1.in.applicationinsights.azure.com/;LiveEndpoint=https://southeastasia.livediagnostics.monitor.azure.com/;ApplicationId=52240843-2df1-4a68-a1a8-fe706bd245a3";
    
           // Setup log4net logger object
           log4net.Config.XmlConfigurator.Configure();
           logger = log4net.LogManager.GetLogger(this.GetType());
       }
    }

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
