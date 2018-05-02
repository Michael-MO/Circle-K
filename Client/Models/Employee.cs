using System;

namespace Client.Models
{
    public class Employee
    {
        public int EmployeeNo { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Address { get; set; }

        public int PostalCode { get; set; }

        public string PhoneNo { get; set; }

        public string Mail { get; set; }

        public bool IsActive { get; set; }

        public int UserName { get; set; }

        public string UserPassword { get; set; }

        public string AccessLevel { get; set; }
    }
}
