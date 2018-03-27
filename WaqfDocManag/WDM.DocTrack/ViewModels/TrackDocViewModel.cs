using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Prism.Regions;
using WDM.Services.Events;
using WDM.Services.ViewModelInfrastructure;

namespace WDM.DocTrack.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class TrackDocViewModel : EditableViewModelBase
    {
        [ImportingConstructor]
        public TrackDocViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            Errors = new Dictionary<string, List<string>>();
            CanClose = true;
            Title = "متابعة معاملة";
            FollowingTypes = new ObservableCollection<string>();
            FollowingTypes.Add("احالة");
            FollowingTypes.Add("صادر");
            FollowingTypes.Add("موعد");

        }
        
        #region Fields
        ObservableCollection<string> _followingTypes;
        string _selectedType;
        IEventAggregator _eventAggregator;
        #endregion

        #region Properties
        public ObservableCollection<string> FollowingTypes
        {
            get { return _followingTypes; }
            set
            {
                SetProperty(ref _followingTypes, value);
                
            }
        }
        public string SelectedType
        {
            get { return _selectedType; }
            set
            {
                SetProperty(ref _selectedType, value);
                _eventAggregator.GetEvent<OneArgEvent<string>>().Publish(_selectedType);
            }
        }
        #endregion


        #region Base
        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public override void OnStateChanged(ViewModelState state)
        {
            switch (state)
            {
                case ViewModelState.AddNew:
                    break;
                case ViewModelState.InEdit:
                    break;
                case ViewModelState.Busy:
                    break;
                case ViewModelState.Saved:
                    break;
                case ViewModelState.Deleted:
                    break;
                
            }
        }

        protected override void AddNew()
        {
            throw new NotImplementedException();
        }

        protected override void Delete()
        {
            throw new NotImplementedException();
        }

        protected override void Initialize()
        {
            
        }

        protected override bool IsValid()
        {
            throw new NotImplementedException();
        }

        protected override void Print()
        {
            throw new NotImplementedException();
        }

        protected override void Save()
        {
            throw new NotImplementedException();
        }

        protected override void Search(object criteria)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
