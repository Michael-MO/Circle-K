using System;
using System.Windows.Input;
using Windows.UI.Popups;
using Client.DataTransformations.ViewData;
using Controllers.Implementation;
using Data.Transformed.Interfaces;
using Model.Interfaces;

namespace Client.ViewModel.Controller
{
    public class DeleteEmployeeController : CRUDControllerBase<EmployeeViewData>, ICommand
    {



        public DeleteEmployeeController(IDataWrapper<EmployeeViewData> source, ICatalog<EmployeeViewData> target, Func<bool> condition) 
            : base(source, target)
        {
                
        }



        public override void Run()
        {
            EmployeeViewData updateObj = Source.DataObject;
            updateObj.IsActive = false;
            updateObj.DeletionDate = DateTime.Now.AddYears(5);
            Target.Update(updateObj, Source.DataObject.Key);
            Source.DataObject.IsActiveButton = false;
            MessageDialog md = new MessageDialog("Ansat slettet - Tryk på tilbage for at komme ud igen.");
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
