using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataTransformations.ViewData;
using Client.Model.App;
using Client.Model.Catalog;
using Commands.Implementation;
using Extensions.Commands.Interfaces;

namespace Client.ViewModel.Page
{
    class DeleteEmployeePageVM : EmployeePageVM
    {
        public DeleteCommandBase<EmployeeViewData> _deleteCommand 
            = new DeleteCommandBase<EmployeeViewData>(ItemSelectedInstance, DomainModel.Instance.Employees, CanDoDelete );

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
