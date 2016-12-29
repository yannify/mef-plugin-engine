using Mef.App.Engine;
using Mef.App.Plugins.Interfaces;
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
        public IEnumerable<string> Get( string descriptor)
        {
            // TODO:  This all belongs in a post that takes in a message
            // only here for ease of testing as we build out the layers

            List<string> output = new List<string>();
            var p = new PluginManager();

            foreach (Lazy<IAppPlugin, IAppPluginMetadata> i in p.Plugins)
            {
                if (i.Metadata.PluginDescriptor.Equals(descriptor))
                {
                    // do stuff here!!!
                   
                }
            }

            return output;
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
