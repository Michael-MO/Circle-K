using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataTransformations.ViewData;
using Commands.Implementation;
using Data.Transformed.Interfaces;
using Model.Interfaces;

namespace Client.ViewModel.Command
{
    public class DeleteEmployeeCommand : DeleteCommandBase<EmployeeViewData>
    {
        public DeleteEmployeeCommand(IDataWrapper<EmployeeViewData> source, ICatalog<EmployeeViewData> target, Func<bool> condition) 
            : base(source, target, condition)
        {

        }
    }
}
