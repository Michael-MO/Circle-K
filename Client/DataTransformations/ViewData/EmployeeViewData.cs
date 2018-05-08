using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataTransformations.Base;

namespace Client.DataTransformations.ViewData
{
    public class EmployeeViewData : ViewDataAppBase
    {

        public string Title { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int EmployeeNumber { get; set; }
        public string Station { get; set; }
        public bool IsActive { get; set; }

        public int ImageKey { get; set; }

        public string AccessLevel { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }


        public override void SetDefaultValues()
        {

            Key = NullKey;
            Name = "(ikke angivet endnu)";
            Address = "(ikke angivet endnu)";
            PhoneNumber = "(ikke angivet endnu)";
            Title = "(ikke angivet endnu)";
            Email = "(ikke angivet endnu)";
            //EmployeeNumber = ; //CHANGE THIS <-- this is an random generated automaticly assigned int  
            Station = "(ikke angivet endnu)";
            IsActive = true; //(måske?) - ændre det så at der er et andet sted som bestemmer om brugeren er aktiv eller ej
            AccessLevel = "(ikke angivet endnu)";
            Username = "(ikke angivet endnu)";
            Password = "(ikke angivet endnu)";
            ImageKey = NullKey;
        }
    }
}
