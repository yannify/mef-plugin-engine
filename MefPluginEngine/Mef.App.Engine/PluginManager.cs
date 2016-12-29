using Mef.App.Plugins.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mef.App.Engine
{
    public class PluginManager
    {
        private CompositionContainer _container;
        [ImportMany]
        public IEnumerable<Lazy<IAppPlugin, IAppPluginMetadata>> Plugins;

        public PluginManager()
        {
            //An aggregate catalog that combines multiple catalogs
            var catalog = new AggregateCatalog();
            //Adds all the parts found in the same assembly as the Program class
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(PluginManager).Assembly));
            catalog.Catalogs.Add(new DirectoryCatalog("C:\\MyData\\MEF_Plugins"));

            //Create the CompositionContainer with the parts in the catalog
            _container = new CompositionContainer(catalog);

            //Fill the imports of this object
            try
            {
                this._container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }
    }
}
