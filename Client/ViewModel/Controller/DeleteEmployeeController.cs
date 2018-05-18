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
        
        // Create a New Object of 'ReasonForRemoval', Which Associates the Reason and the Employee.
        // This is an Alternative to Having a 'Reason' Property in the Employee Object.

        // new ReasonForRemoval();
        // PER!!?


        // make sure to set date from now to 5 years forward
        // have a terminationDate instance string that date time can manipulate

        public override void Run()
        {
            EmployeeViewData updateObj = Source.DataObject.Copy() as EmployeeViewData;
            updateObj.IsActive = false;
            Target.Update(updateObj, Source.DataObject.Key);
        }
    }
}
