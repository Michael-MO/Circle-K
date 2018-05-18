using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataTransformations.PersistentData;
using Client.DataTransformations.PersistentData.EmployeePersistentData;
using Client.DataTransformations.ViewData;
using Client.Model.Base;

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
                vdObj.EmployeeNo,
                vdObj.Title,
                vdObj.Name,
                vdObj.Address,
                vdObj.PostalCode,
                vdObj.PhoneNo,
                vdObj.Mail,
                vdObj.Station,
                vdObj.IsActive,
                vdObj.DeletionDate,
                vdObj.TerminationReason,
                vdObj.Username,
                vdObj.Password,
                vdObj.AccessLevel,
                vdObj.Key
            );
        }
        
        public override EmployeeViewData CreateViewDataObject(Model.Domain.Employee obj)
        {
            return new EmployeeViewData
            {
                //Implementation
                Key = obj.Key,
                Title = obj.Title.TrimEnd(' '),
                Name = obj.Name.TrimEnd(' '),
                Address = obj.Address.TrimEnd(' '),
                Mail = obj.Mail.TrimEnd(' '),
                TerminationReason = obj.TerminationReason.TrimEnd(' ')
            };
        }

        public override EmployeePersistentData CreatePersistentDataObject(Model.Domain.Employee obj)
        {
            return new EmployeePersistentData
            {
                //Implementation
                Key = obj.Key,
                Title = obj.Title,
                Name = obj.Name,
                Address = obj.Address,
                Mail = obj.Mail,
                Station = obj.Station,
                TerminationReason = obj.TerminationReason   
                //NOTICE! -  possibly add rest of the propperties
            };
        }

        public override Model.Domain.Employee CreateDomainObjectFromPersistentDataObject(EmployeePersistentData pdObj)
        {
            return new Model.Domain.Employee
            (
                pdObj.EmployeeNo,
                pdObj.Title,
                pdObj.Name,
                pdObj.Address,
                pdObj.PostalCode,
                pdObj.PhoneNo,
                pdObj.Mail,
                pdObj.Station,
                pdObj.IsActive,
                pdObj.DeletionDate,
                pdObj.TerminationReason,
                pdObj.Username,
                pdObj.Password,
                pdObj.AccessLevel,
                pdObj.Key
            );
        }
    }
}
