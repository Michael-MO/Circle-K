using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataTransformations.Base;
using Client.Model.Domain;

namespace Client.DataTransformations.ViewData
{
    public class EmployeeViewData : ViewDataAppBase
    {
        public int EmployeeNo { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
        
        public int PostalCode { get; set; }

        public string PhoneNo { get; set; }

        public string Mail { get; set; }

        public List<Station> Station { get; set; }

        public bool IsActive { get; set; }

        public DateTime DeletionDate { get; set; }

        public string TerminationReason { get; set; }

        public string Cpr { get; set; }

        public int ImageKey { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string AccessLevel { get; set; }

        public bool _popupactive { get; set; }

        public override void SetDefaultValues()
        {
            Key = NullKey;
            Name = "";
            Address = "";
            PostalCode = 1000;
            PhoneNo = "";
            Title = "";
            Mail = "";
            // EmployeeNo = ; //CHANGE THIS <-- this is an random generated automaticly assigned int  
            Station = null;
            IsActive = true; //(måske?) - ændre det så at der er et andet sted som bestemmer om brugeren er aktiv eller e
            DeletionDate = DateTime.Now;
            TerminationReason = "";
            Cpr = "";
            AccessLevel = "";
            Username = "";
            Password = "";
            _popupactive = false;
            // ImageKey = NullKey;
        }
    }
}
