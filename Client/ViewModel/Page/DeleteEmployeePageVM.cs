using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataTransformations.ViewData;
using Client.Model.App;
using Client.ViewModel.Controller;
using Commands.Implementation;
using Data.Transformed.Interfaces;
using Extensions.Commands.Interfaces;

namespace Client.ViewModel.Page
{
    public class DeleteEmployeePageVM : EmployeePageVM
    {
        private DeleteEmployeeController _deleteEmployeeController;
        private IDataWrapper<EmployeeViewData> _deleteInstance;
        public DeleteCommandBase<EmployeeViewData> _deleteCommand
            = new DeleteCommandBase<EmployeeViewData>(ItemSelectedInstance, DomainModel.Instance.Employees, CanDoDelete);

        public DeleteEmployeePageVM()
        {
            _deleteInstance = ItemSelectedInstance;
            ItemSelectedInstance = null;
            _deleteEmployeeController = new DeleteEmployeeController(_deleteInstance, DomainModel.Instance.Employees, CanDoDelete);
        }

        public IDataWrapper<EmployeeViewData> DeleteInstance    
        {
            get { return _deleteInstance; }
            set
            {
                _deleteInstance = value;
                OnPropertyChanged();
            }
        }

        public DeleteEmployeeController DeleteEmployeeController
        {
            get { return _deleteEmployeeController; }
        }

        protected override void SetupInitialViewState()
        {
            ViewStateService.ViewState = CRUDStates.UpdateState;
        }

        private static bool CanDoDelete()
        {
            return true;
        }


        //method to set employee _isActive = false

    }
}
