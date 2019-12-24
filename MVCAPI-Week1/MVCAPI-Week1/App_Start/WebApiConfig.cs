using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MVCAPI_Week1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //Default Web API Mapping
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/org/{controller}/{id}",
                defaults: new { controller = "Basic", id = RouteParameter.Optional }
            );

            //What WebAPI is supposed to look like
            config.Routes.MapHttpRoute(
                name: "BasicAPI",
                routeTemplate: "api/basic/{id}",
                defaults: new { controller = "Basic", id = RouteParameter.Optional }
            );

            //Customized WebAPI
            config.Routes.MapHttpRoute(
                name: "ComplexWebAPI",
                routeTemplate: "api/complex/{action}/{id}",
                defaults: new { controller = "Complex", id = RouteParameter.Optional }
            );
        }
    }
}