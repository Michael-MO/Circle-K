using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions.Commands.Interfaces;

namespace Client.ViewModel.Page
{
    class DeleteEmployeePageVM : EmployeePageVM
    {

        



        protected override void SetupInitialViewState()
        {
            ViewStateService.ViewState = CRUDStates.UpdateState;
        }

        //method to set employee _isActive = false

    }
}
