using System;
using Client.DataTransformations.ViewData;
using Data.Transformed.Interfaces;
using Model.Interfaces;
using Controllers.Implementation;

namespace Client.ViewModel.Controller
{
    public class UpdateEmployeeController : CRUDControllerBase<EmployeeViewData>
    {
        public UpdateEmployeeController(IDataWrapper<EmployeeViewData> source, ICatalog<EmployeeViewData> target, Func<bool> condition) 
            : base(source, target)
        {
        }

        public override void Run()
        {
            EmployeeViewData updateObj = Source.DataObject;
            Target.Update(updateObj, Source.DataObject.Key);
        }
    }
}
