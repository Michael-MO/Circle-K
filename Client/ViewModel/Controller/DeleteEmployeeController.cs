using System;
using Client.DataTransformations.ViewData;
using Controllers.Implementation;
using Data.Transformed.Interfaces;
using Model.Interfaces;

namespace Client.ViewModel.Controller
{
    public class DeleteEmployeeController : CRUDControllerBase<EmployeeViewData>
    {
        public DeleteEmployeeController(IDataWrapper<EmployeeViewData> source, ICatalog<EmployeeViewData> target, Func<bool> condition) 
            : base(source, target)
        {
        }

        public override void Run()
        {
            EmployeeViewData updateObj = Source.DataObject;
            updateObj.IsActive = false;
            // updateObj.DeletionDate = DateTime.Now.AddYears(5);
            Target.Update(updateObj, Source.DataObject.Key);
        }
    }
}
