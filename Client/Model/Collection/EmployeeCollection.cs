using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Model.Domain;
using Client.WebAPI;

namespace Client.Model.Collection
{
    public class EmployeeCollection
    {
        private static EmployeeCollection instance;
        private static Dictionary<int, Employee> _collection;
        public event Action OnLoadEnded;

        private EmployeeCollection()
        {
            _collection = new Dictionary<int, Employee>();
            LoadWrapper();
        }

        private async void LoadWrapper()
        {
            List<Employee> emps = await Load();
            foreach (var emp in emps)
            {
                _collection.Add(emp.EmployeeNo, emp);
            }

            OnLoadEnded?.Invoke();
        }

        private async Task<List<Employee>> Load()
        {
            const string serverURL = "http://localhost:55985";
            const string employeeURI = "Employees";

            const string apiPrefix = "api";

            //throw new NotImplementedException("Uncomment the code below to test the Web Service");

            WebAPIAsync<Employee> employeeWebApi = new WebAPIAsync<Employee>(serverURL, apiPrefix, employeeURI);

            return await employeeWebApi.Load();
        }

        public static EmployeeCollection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeCollection();
                }
                return instance;
            }
        }

        public Dictionary<int, Employee> Collection
        {
            get { return _collection; }
            set { _collection = value; }
        }
    }
}
