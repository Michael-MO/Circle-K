using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ViewModel.Data;
using Commands.Implementation;
using Data.Transformed.Interfaces;
using Model.Interfaces;

namespace Client.ViewModel.Command
{
    public class CreateEmployeeCommand : CreateCommandBase<EmployeeDataViewModel>
    {
        public CreateEmployeeCommand(IDataWrapper<EmployeeDataViewModel> source, ICatalog<EmployeeDataViewModel> target, Func<bool> condition)
            : base(source, target, condition)
        {
        }
    }
}
