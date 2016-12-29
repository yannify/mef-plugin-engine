using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mef.App.WebApi.Controllers
{
    public class ExecutesController : ApiController
    {
        // GET: api/Executes
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Executes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Executes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Executes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Executes/5
        public void Delete(int id)
        {
        }
    }
}
