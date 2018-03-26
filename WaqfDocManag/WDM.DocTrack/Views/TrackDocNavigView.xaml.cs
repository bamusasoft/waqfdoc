using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WDM.Services;

namespace WDM.DocTrack.Views
{
    [Export]
    [ViewSortHint("01")]
    public partial class TrackDocNavigView : UserControl
    {
        public TrackDocNavigView()
        {
            InitializeComponent();
        }

        #region Fields
        private static readonly Uri _addDocViewUri = new Uri("/AddDocView", UriKind.Relative);
        private static readonly Uri _addTrackViewUri = new Uri("/TrackDocView", UriKind.Relative);
        [Import]
        public IRegionManager RegionManager;
        #endregion
        private void OnNavigateToAddDoc(object sender, RoutedEventArgs e)
        {
            RegionManager.RequestNavigate(RegionNames.MAIN_CONTENT_REGION, _addDocViewUri);
        }

        private void OnNavigateToTrack(object sender, RoutedEventArgs e)
        {
            RegionManager.RequestNavigate(RegionNames.MAIN_CONTENT_REGION, _addTrackViewUri);
        }

        
    }
}
