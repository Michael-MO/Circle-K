﻿using Client.DataTransformations.ViewData;
using Client.Model.App;
using Client.ViewModel.Controller;
using Commands.Implementation;
using Data.Transformed.Interfaces;
using Extensions.Commands.Interfaces;

namespace Client.ViewModel.Page
{
    public class UpdateEmployeePageVM : EmployeePageVM
    {
        private UpdateEmployeeController _updateEmployeeController;
        private IDataWrapper<EmployeeViewData> _updateInstance;
        public UpdateCommandBase<EmployeeViewData> _updateCommand 
            = new UpdateCommandBase<EmployeeViewData>(ItemSelectedInstance, DomainModel.Instance.Employees, CanDoUpdate);

        public UpdateEmployeePageVM()
        {
            _updateInstance = ItemSelectedInstance;
            ItemSelectedInstance = null;
            _updateEmployeeController = new UpdateEmployeeController(_updateInstance, DomainModel.Instance.Employees, CanDoUpdate);
        }

        public IDataWrapper<EmployeeViewData> UpdateInstance
        {
            get { return _updateInstance; }
            set
            {
                _updateInstance = value;
                OnPropertyChanged();
            }
        }

        public UpdateEmployeeController UpdateEmployeeController
        {
            get { return _updateEmployeeController; }
        }

        protected override void SetupInitialViewState()
        {
            ViewStateService.ViewState = CRUDStates.UpdateState;
        }

        private static bool CanDoUpdate()
        {
            return true;
        }
    }
}
