using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Catalog
{
    public class EmployeeCatalog : CatalogAppBase<Model.Domain.Employee, EmployeeViewData, EmployeePersistentData>
    {
        public EmployeeCatalog() : base("Employees")
        {
        }

        public override Model.Domain.Employee CreateDomainObjectFromViewDataObject(EmployeeViewData vdObj)
        {
            return new Model.Domain.Employee
            (
                //Implementation 






            );
        }


        public override EmployeeViewData CreateViewDataObject(Model.Domain.Employee obj)
        {
            return new EmployeeViewData
            {
                //Implementation





            }
        }

        public override EmployeePersistentData CreatePersistentDataObject(Model.Domain.Employee obj)
        {
            return new EmployeePersistentData
            {
                //Implementation




            }
        }

        public override Model.Domain.Employee CreateDomainObjectFromFromPersistentDataObject(
            EmployeePersistentData pdObj)
        {
            return new Model.Domain.Employee
            (
                //Implementation



            );
        }






    }
}
