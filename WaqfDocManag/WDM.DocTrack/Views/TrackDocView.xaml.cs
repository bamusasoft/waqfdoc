using Prism.Events;
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
using WDM.DocTrack.ViewModels;
using WDM.Services.Events;

namespace WDM.DocTrack.Views
{
    /// <summary>
    /// Interaction logic for TrackDoc.xaml
    /// </summary>
    [Export("TrackDocView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TrackDocView : UserControl
    {

        IEventAggregator _eventAggregator;
        public TrackDocView()
        {
            InitializeComponent();
        }
        [ImportingConstructor]
        public TrackDocView(IEventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OneArgEvent<string>>().Subscribe(OnSelectedTypeChanged);
        }

        [Import]
        public TrackDocViewModel ViewModel
        {
            get { return DataContext as TrackDocViewModel; }
            set { DataContext = value; }
        }
        private void OnSelectedTypeChanged(string s)
        {
            trackContentPresenter.Content = s;

        }
    }
}
