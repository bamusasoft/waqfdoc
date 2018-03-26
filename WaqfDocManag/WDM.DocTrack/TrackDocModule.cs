using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDM.DocTrack.Views;
using WDM.Services;

namespace WDM.DocTrack
{
   [ModuleExport(typeof(TrackDocModule))]
    public class TrackDocModule:IModule
    {

        [Import]
        public IRegionManager RegionManager;

        public void Initialize()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.MAIN_NAVIGATION_REGION, typeof(TrackDocNavigView));
        }
    }
}
