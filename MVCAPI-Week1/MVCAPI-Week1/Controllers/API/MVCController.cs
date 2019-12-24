using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAPI_Week1.Controllers
{
    //Routing to apix for those with Route Paramters
    //Otherwise RouteConfig mapping holds
    [RoutePrefix("apix")]
    public class MVCController : Controller
    {
        /// <summary>
        /// URL: apix/
        /// Note no HelloWorld due to the Route parameter
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route]
        public JsonResult HelloWorld()
        {
            return Json("Hello World", JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// URL: apix/HX2/{id}
        /// Note the definition of ID in route attribute
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("HX2/{id}")]
        public JsonResult HelloWorld2(string id)
        {
            return Json($"Hello World2: {id}", JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Route Attribute not applied
        /// ActionName renames the function to another url
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("heehee")]
        public JsonResult HelloWorldRouted(string id)
        {
            return Json($"Hello World-Routed: {id}", JsonRequestBehavior.AllowGet);
        }
    }
}