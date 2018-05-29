using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Client.DataTransformations.ViewData;
using Data.Transformed.Interfaces;
using Model.Interfaces;
using Controllers.Implementation;

namespace Client.ViewModel.Controller
{
    public class UpdateEmployeeController : CRUDControllerBase<EmployeeViewData>, ICommand
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
