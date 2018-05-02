using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Domain
{
    public class Employee: User
    {
        private string _title;
        private string _name;
        private string _address;
        private string _phoneNumber;
        private string _email;
        private int _employeeNumber;
        private string _station;
        private bool _isActive;

        public Employee(string title, string name, string address, string phoneNumber, string email,
            int employeeNumber, string station, bool isActive, string accessLevel, string username, string password)
            : base(accessLevel, username, password)
        {
            _title = title;
            _name = name;
            _address = address;
            _phoneNumber = phoneNumber;
            _email = email;
            _employeeNumber = employeeNumber;
            _station = station;
            _isActive = isActive;
        }

        public string Title
        {
            get { return _title; }
        }

        public string Name
        {
            get { return _name; }
        }
        public string Address
        {
            get { return _address; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }
        public string Email
        {
            get { return _email; }
        }
        public int EmployeeNumber
        {
            get { return _employeeNumber; }
        }
        public string Station
        {
            get { return _station; }
        }
        public bool IsActive
        {
            get { return _isActive; }
        }


        public void ChangeTitle(string title) //, this.accesslevel) //sørg for at få denne refference til employee objektets accesslevel fra user classen 
        {
            // check - compare dictionary <string (title forstås her), list<title (en komplet liste over alle titler)>>
            // ChangeAccesslevel(Employee obj, accessLevel (wished to change to)); //call the other method with 

        }



    }
}
