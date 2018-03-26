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

namespace WDM.DocTrack.Views
{
    /// <summary>
    /// Interaction logic for TrackDoc.xaml
    /// </summary>
    [Export("TrackDocView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TrackDocView : UserControl
    {
        
        public TrackDocView()
        {
            InitializeComponent();
        }

        //[Import]
        //public PaymentViewModel ViewModel
        //{
        //    get { return DataContext as PaymentViewModel; }
        //    set { DataContext = value; }
        //}
    }
}
