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
        public IExecutionResult Get(string pluginDescriptor, string command)
        {
            // TODO:  This all belongs in a post that takes in a message
            // only here for ease of testing as we build out the layers

            IExecutionResult result;
            var manager = new PluginManager();

            foreach (Lazy<IAppPlugin, IAppPluginMetadata> plugin in manager.Plugins)
            {
                if (plugin.Metadata.PluginDescriptor.Equals(pluginDescriptor))
                {
                    // do stuff here!!!
                    plugin.Value.PreExecute(new Dictionary<string, object>());
                    result = plugin.Value.ExecuteCommand(command, new Dictionary<string, object>());
                    plugin.Value.PostExecute(new Dictionary<string, object>());

                    return result;
                }
            }

            return null;
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
