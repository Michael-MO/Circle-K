using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Client.DataTransformations.ViewData;
using Client.Model.App;
using Client.Model.Domain;
using Client.ViewModel.Base;
using Client.ViewModel.Data;
using Commands.Implementation;
using Data.Transformed.Interfaces;

namespace Client.ViewModel.Page
{
    public class EmployeePageVM : PageViewModelAppBase<EmployeeViewData>
    {
        private bool _buttonBool;
        private IDataWrapper<EmployeeViewData> _employeeInstance;

        public EmployeePageVM() : base(DomainModel.Catalogs.Employees, new List<string> {"Name"}, new List<string> {"PhoneNo", "Mail", "Address", "PostalCode", "Station", "Title", "IsActive", "TerminationReason", "Cpr", "Usename", "Password", "AccessLevel", "_popupActive"})
        {
            _employeeInstance = EmployeePageVM.ItemSelectedInstance;
            _buttonBool = false;
        }

        public IDataWrapper<EmployeeViewData> EmployeeInstance
        {
            get { return _employeeInstance; }
            set { _employeeInstance = value; }
        }
            
        public override IDataWrapper<EmployeeViewData> CreateDataViewModel(EmployeeViewData obj)
        {
            return new EmployeeDataViewModel(obj);
        }

        public bool ButtonBool
        {
            get { return _buttonBool; }
            set
            {
                _buttonBool = true;
                OnPropertyChanged();
            }
        }
    }
}
