using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mef.App.Plugins.Interfaces
{
    public interface IExecutionResult
    {
        bool IsSuccess { get; }
        IDictionary<string, object> Output { get; }
    }
}
