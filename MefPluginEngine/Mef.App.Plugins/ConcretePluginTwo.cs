using Mef.App.Plugins;
using Mef.App.Plugins.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mef.App.Plugins
{

    [Export(typeof(IAppPlugin))]
    [ExportMetadata("PluginDescriptor", "mef.app.plugins.concrete_plugin_two")]
    [ExportMetadata("SomeOtherData", "bar")]
    public class ConcretePluginTwo: IAppPlugin
    {
        public IExecutionResult ExecuteCommand(string commandKey, Dictionary<string, object> input)
        {
            return _commands[commandKey].Execute(input);
        }

        public IExecutionResult PostExecute(IDictionary<string, object> input)
        {
            // no-op
            return new ExecutionResult(true, new Dictionary<string, object>());
        }

        public IExecutionResult PreExecute(IDictionary<string, object> input)
        {
            return new ExecutionResult(true, new Dictionary<string, object>());
        }

        private Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>
        {
            {"Command_Three", new CommandThree() },
            {"Command_Four", new CommandFour() }
        };
    }

    public class CommandThree : ICommand
    {
        public IExecutionResult Execute(IDictionary<string, object> input)
        {
            return new ExecutionResult(true, new Dictionary<string, object> {
                { "ResultOne", "Greetings from CommandThree in ConcretePluginTwo!" }
            });
        }
    }

    public class CommandFour : ICommand
    {
        public IExecutionResult Execute(IDictionary<string, object> input)
        {
            return new ExecutionResult(true, new Dictionary<string, object> {
                { "ResultOne", "Greetings from CommandFour in ConcretePluginTwo!" },
                { "ResultTwo", false }
            });
        }
    }
}