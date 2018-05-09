using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataTransformations.Base;

namespace Client.DataTransformations.PersistentData.EmployeePersistentData
{
    public class EmployeePersistentData : PersistentDataAppBase
    {
        public string Title { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int EmployeeNumber { get; set; }
        public string Station { get; set; }
        public bool IsActive { get; set; }

 //       public string ImageKey { get; set; }

        public string AccessLevel { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }


    }
}
