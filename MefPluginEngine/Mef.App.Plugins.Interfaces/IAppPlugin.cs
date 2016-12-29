using Mef.App.Plugins.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mef.App.Plugins.Interfaces
{
    public interface IAppPlugin
    {
        IExecutionResult PreExecute(IDictionary<string, object> input);
        IExecutionResult PostExecute(IDictionary<string, object> input);
        IExecutionResult ExecuteCommand(string commandKey, Dictionary<string, object> input);
    }
}
