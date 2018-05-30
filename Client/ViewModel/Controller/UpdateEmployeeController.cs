using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
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
            Source.DataObject.IsActiveButton = false;
            MessageDialog md = new MessageDialog("Data opdateret - Tryk på tilbage for at komme ud igen.");
            md.ShowAsync();
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
