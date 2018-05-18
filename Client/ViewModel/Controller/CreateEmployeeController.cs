using System;
using Client.DataTransformations.ViewData;
using Client.ViewModel.Data;
using Controllers.Implementation;
using Data.Transformed.Implementation;
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

            string PW = GeneratePW();

            Source.DataObject.Password = PW;



            if (SendMail(PW) == true)
            {
                Target.Create(Source.DataObject);
            }
        }

        //bruger source email til at sende en besked til nyoprettet bruger med password
        private bool SendMail(string PW)
        {
            return true;
        }

        private string GeneratePW()
        {
            return "test123";
        }
    }
}
