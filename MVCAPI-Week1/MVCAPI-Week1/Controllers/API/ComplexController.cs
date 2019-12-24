using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCAPI_Week1.Controllers
{
    public class ComplexController : ApiController
    {
        [HttpGet]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [HttpGet]
        public string HelloWorld2(string id)
        {
            return $"Hello World2: {id}";
        }
    }
}
