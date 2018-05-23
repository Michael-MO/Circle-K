using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Domain
{
    public class Employee : User
    {
        public Employee(
            int employeeNo,
            string title,
            string name,
            string address,
            int postalCode,
            string phoneNo,
            string mail,
            List<Station> station,
            bool isActive,
            DateTime deletionDate,
            string terminationReason,
            string cpr,
            string userName,
            string userPassword,
            string accessLevel,
            int key)
            : base(userName, userPassword, accessLevel, key)
        {
            Key = employeeNo;
            EmployeeNo = employeeNo;
            Title = title;
            Name = name;
            Address = address;
            PostalCode = postalCode;
            PhoneNo = phoneNo;
            Mail = mail;
            Station = station;
            IsActive = isActive;
            DeletionDate = deletionDate;
            TerminationReason = terminationReason;
            Cpr = cpr;
        }

        public int EmployeeNo { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Address { get; set; }

        public int PostalCode { get; set; }

        public string PhoneNo { get; set; }

        public string Mail { get; set; }

        public List<Station> Station { get; set; }

        public bool IsActive { get; set; }

        public DateTime DeletionDate { get; set; }

        public string TerminationReason { get; set; }

        public string Cpr { get; set; }

        public void ChangeTitle(string title) //, this.accesslevel) //sørg for at få denne refference til employee objektets accesslevel fra user classen 
        {
            // check - compare dictionary <string (title forstås her), list<title (en komplet liste over alle titler)>>
            // ChangeAccesslevel(Employee obj, accessLevel (wished to change to)); //call the other method with 
        }
    }
}
