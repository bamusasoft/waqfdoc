using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDM.Services.ViewModelInfrastructure;

namespace WDM
{
    [Export(typeof(ISettings))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class WdmSettings : ISettings
    {
        public object this[string propertyName]
        {
            get { return Properties.Settings.Default[propertyName]; }
            set { Properties.Settings.Default[propertyName] = value; }
        }

        public void Save()
        {
            Properties.Settings.Default.Save();
        }
    }
}
