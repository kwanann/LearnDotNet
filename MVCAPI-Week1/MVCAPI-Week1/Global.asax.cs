using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCAPI_Week1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //API first
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //Then filters
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            //MVC routing
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //JS and CSS bundles
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
