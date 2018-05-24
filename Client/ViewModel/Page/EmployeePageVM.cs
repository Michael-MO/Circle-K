using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataTransformations.ViewData;
using Client.Model.App;
using Client.Model.Domain;
using Client.ViewModel.Base;
using Client.ViewModel.Data;
using Data.Transformed.Interfaces;

namespace Client.ViewModel.Page
{
    public class EmployeePageVM : PageViewModelAppBase<EmployeeViewData>
    {
        private IDataWrapper<EmployeeViewData> _employeeInstance;

        public EmployeePageVM() : base(DomainModel.Catalogs.Employees, new List<string> {"Name"}, new List<string> {"123"})
        {
            _employeeInstance = EmployeePageVM.ItemSelectedInstance;
        }

        public IDataWrapper<EmployeeViewData> EmployeeInstance
        {
            get { return _employeeInstance; }
            set { _employeeInstance = value; }
        }

        public IEnumerable<IDataWrapper<EmployeeViewData>> ItemCollectionActive
        {
            get { return ItemCollection.Where(e => e.DataObject.IsActive == true); }
        }
            
        public override IDataWrapper<EmployeeViewData> CreateDataViewModel(EmployeeViewData obj)
        {
            return new EmployeeDataViewModel(obj);
        }
    }
}
