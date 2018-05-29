using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;
using Windows.Security.Cryptography.Core;
using AddOns.ViewState.Implementation;
using Client.DataTransformations.ViewData;
using Client.Model.App;
using Client.ViewModel.Base;
using Client.ViewModel.Controller;
using Client.ViewModel.Data;
using Commands.Implementation;
using Data.InMemory.Interfaces;
using Data.Transformed.Implementation;
using Data.Transformed.Interfaces;
using Extensions.Commands.Interfaces;
using Model.Interfaces;
using ViewModel.Page.Implementation;

namespace Client.ViewModel.Page
{
    public class CreateEmployeePageVM : EmployeePageVM
    {
        private CreateEmployeeController _createEmployeeController;
        private IDataWrapper<EmployeeViewData> _createInstance;
        public CreateCommandBase<EmployeeViewData> _createCommand 
            = new CreateCommandBase<EmployeeViewData>(ItemSelectedInstance, DomainModel.Instance.Employees, CanDoCreate);

        public CreateEmployeePageVM()   
        {
            
            _createInstance = CreateDataViewModelFromNewViewData();
            _createEmployeeController = new CreateEmployeeController(_createInstance, DomainModel.Instance.Employees, CanDoCreate);


        }

        public IDataWrapper<EmployeeViewData> CreateInstance
        {
            get { return _createInstance; }
            set
            {
                _createInstance = value;
                OnPropertyChanged();
            }
        }

        public CreateEmployeeController CreateEmployeeController
        {
            get { return _createEmployeeController; }
        }

        protected override void SetupInitialViewState()
        {
            ViewStateService.ViewState = CRUDStates.CreateState;
        }

        private static bool CanDoCreate()
        {
            return true;
        }
    }
}
