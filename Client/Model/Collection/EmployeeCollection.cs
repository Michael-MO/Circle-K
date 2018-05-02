using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Model.Domain;

namespace Client.Model.Collection
{
    public class EmployeeCollection
    {
        private static EmployeeCollection instance;
        private static Dictionary<int, Employee> _collection;

        private EmployeeCollection()
        {
            _collection = new Dictionary<int, Employee>();
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
        }

    }
}
