using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ViewModel.Data;
using Commands.Implementation;
using Data.Transformed.Interfaces;
using Model.Interfaces;

namespace Client.ViewModel.Controller
{
    public class CreateEmployeeController : CreateCommandBase<EmployeeDataViewModel>
    {
        public CreateEmployeeController(IDataWrapper<EmployeeDataViewModel> source, ICatalog<EmployeeDataViewModel> target, Func<bool> condition)
            : base(source, target, condition)
        {
        }
    }
}
