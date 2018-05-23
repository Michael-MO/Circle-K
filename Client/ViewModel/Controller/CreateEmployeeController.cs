using System;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Client.DataTransformations.ViewData;
using Client.ViewModel.App;
using Client.ViewModel.Data;
using Controllers.Implementation;
using Data.Transformed.Implementation;
using Data.Transformed.Interfaces;
using Model.Interfaces;

namespace Client.ViewModel.Controller
{
    public class CreateEmployeeController : CRUDControllerBase<EmployeeViewData>, ICommand
    {
        private AppViewModel nav;

        public CreateEmployeeController(IDataWrapper<EmployeeViewData> source, ICatalog<EmployeeViewData> target, Func<bool> condition)
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

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Run();
        }

        public event EventHandler CanExecuteChanged;
    }
}
