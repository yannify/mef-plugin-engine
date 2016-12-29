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
    [ExportMetadata("PluginDescriptor", "mef.app.plugins.concrete_plugin_one")]
    [ExportMetadata("SomeOtherData", "foo")]
    public class ConcretePluginOne: IAppPlugin
    {
    }
}
