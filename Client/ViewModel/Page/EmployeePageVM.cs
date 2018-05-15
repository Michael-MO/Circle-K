using System;
using System.Collections.Generic;
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
        public EmployeePageVM() : base(DomainModel.Catalogs.Employees, new List<string> {"Name"}, new List<string> {"123"})
        {
        }

        public override IDataWrapper<EmployeeViewData> CreateDataViewModel(EmployeeViewData obj)
        {
            return new EmployeeDataViewModel(obj);
        }
    }
}
