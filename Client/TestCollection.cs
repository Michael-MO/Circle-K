using Client.Model.Collection;
using Client.Model.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class TestCollection : INotifyPropertyChanged
    {
        private Dictionary<int, Employee> _collection;

        public TestCollection()
        {
            _collection = EmployeeCollection.Instance.Collection;
            EmployeeCollection.Instance.OnLoadEnded += OnLoadEndedHandler;
        }

        public List<Employee> Collection
        {
            get { return _collection.Values.ToList(); }
        }

        private void OnLoadEndedHandler()
        {
            OnPropertyChanged(nameof(Collection));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
