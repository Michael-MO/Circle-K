using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;
using AddOns.ViewState.Implementation;
using Client.DataTransformations.ViewData;
using Client.ViewModel.Base;
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
        private IDataWrapper<EmployeeViewData> _Connection;

        public CreateEmployeePageVM()
        {
            _Connection = CreateDataViewModelFromNewViewData();
            
        }

        protected override void SetupInitialViewState()
        {
            ViewStateService.ViewState = CRUDStates.CreateState;
        }

        
        
    }
}
