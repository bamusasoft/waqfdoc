using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Regions;
using WDM.Services;
using WDM.Services.ViewModelInfrastructure;

namespace WDM.DocTrack.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class AddDocViewModel : EditableViewModelBase
    {
        public AddDocViewModel(ILogger logger)
        {
            if (logger == null) throw new ArgumentNullException("logger");
            _logger = logger;
            CanClose = true;
            Title = ViewModelsTitles.ADD_DOC;
        }
        #region Fields
        ILogger _logger;
        string _docNo;
        string _docDate;
        string _title;
        string _description;

        #endregion
        #region Proeprties

        #endregion
        #region "Base"
        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public override void OnStateChanged(ViewModelState state)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
