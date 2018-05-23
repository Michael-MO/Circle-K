using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Client.Views.Domain;

namespace Client.ViewModel.App
{
    class AppViewModel : INotifyPropertyChanged
    {

        private NavigationViewItem _selectedMenuItem;
        public Dictionary<string, ICommand> NavigationCommands { get; }
        public Frame MainAppFrame { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public AppViewModel()
        {
            _selectedMenuItem = null;
            NavigationCommands = new Dictionary<string, ICommand>();
            AddCommands();
        }

        public NavigationViewItem SelectedMenuItem
        {
            get { return _selectedMenuItem; }
            set
            {
                _selectedMenuItem = value;
                if (_selectedMenuItem == null) return;

                string tag = _selectedMenuItem.Tag.ToString();

                if (!NavigationCommands.ContainsKey(tag))
                {
                    throw new ArgumentException($"Menu entry {tag} has no matching navigation command");
                }

                NavigationCommands[tag].Execute(null);
            }
        }

        public void AddCommands()
        {
            NavigationCommands.Add("MainMenu", new RelayCommand(() =>
            {
                MainAppFrame.Navigate(typeof(Views.Domain.MainMenu));
            }));

            NavigationCommands.Add("OpenEmployeeView", new RelayCommand(() =>
            {
                MainAppFrame.Navigate(typeof(EmployeeView));
            }));

            NavigationCommands.Add("OpenCustomerView", new RelayCommand(() =>
            {
                MainAppFrame.Navigate(typeof(MainMenu));
            }));


            //NavigationCommands.Add("Login", new RelayCommand(() =>
            //{
            //    MainAppFrame.Navigate(typeof(Login));
            //}));

            //NavigationCommands.Add("OpenSaleView", new RelayCommand(() =>
            //{
            //    AppFrame.Navigate(typeof(SaleView));
            //}));
        }




        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        //}

    }
}
