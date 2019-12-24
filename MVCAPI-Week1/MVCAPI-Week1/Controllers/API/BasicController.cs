using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCAPI_Week1.Controllers
{
    public class BasicController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/api2/5
        public string Get(int id)
        {
            return $"value: {id}";
        }

        // POST: api/student
        public string Post([FromBody]string value)
        {
            return $"Post: {value}";
        }

        // PUT: api/student/5
        public string Put(int id, [FromBody]string value)
        {
            return $"Put: {id}, {value}";
        }

        // DELETE: api/student/5
        public string Delete(int id)
        {
            return $"Delete: {id}";
        }
    }
}
