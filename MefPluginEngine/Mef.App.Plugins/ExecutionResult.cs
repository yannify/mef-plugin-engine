using Mef.App.Plugins.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mef.App.Plugins
{
    public class ExecutionResult : IExecutionResult
    {
        public bool IsSuccess { get; private set; }
        public IDictionary<string, object> Output { get; private set; }

        public ExecutionResult(bool isSuccess, IDictionary<string, object> output)
        {
            this.IsSuccess = isSuccess;
            this.Output = output;
        }
    }
}
