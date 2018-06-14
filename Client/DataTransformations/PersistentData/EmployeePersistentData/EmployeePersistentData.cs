using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataTransformations.Base;
using Client.Model.Domain;

namespace Client.DataTransformations.PersistentData.EmployeePersistentData
{
    public class EmployeePersistentData : PersistentDataAppBase
    {
        public int EmployeeNo { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int PostalCode { get; set; }

        public string PhoneNo { get; set; }

        public string Mail { get; set; }

        //public List<Station> Station { get; set; }

        public bool IsActive { get; set; }

        public DateTime DeletionDate { get; set; }

        public string TerminationReason { get; set; }

        public string Cpr { get; set; }

        //public int ImageKey { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public string AccessLevel { get; set; }

        public override int Key
        {
            get { return EmployeeNo;}
            set { }
        }
    }
}
