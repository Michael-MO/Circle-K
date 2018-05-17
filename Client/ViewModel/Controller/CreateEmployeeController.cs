using System;
using Client.ViewModel.Data;
using Controllers.Implementation;
using Data.Transformed.Interfaces;
using Model.Interfaces;

namespace Client.ViewModel.Controller
{
    public class CreateEmployeeController : CRUDControllerBase<EmployeeDataViewModel>
    {
        public CreateEmployeeController(IDataWrapper<EmployeeDataViewModel> source, ICatalog<EmployeeDataViewModel> target, Func<bool> condition)
            : base(source, target)
        {
        }

        public override void Run()
        {
            return;
        }
    }
}
