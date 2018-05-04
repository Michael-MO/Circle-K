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
                vdObj.Title,
                vdObj.Name,
                vdObj.Address,
                vdObj.PhoneNumber,
                vdObj.Email,
                vdObj.EmployeeNumber,
                vdObj.Station,
                vdObj.IsActive,
                vdObj.AccessLevel,
                vdObj.Username,
                vdObj.Password,
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
                Email = obj.Email.TrimEnd(' '),
                Station = obj.Station.TrimEnd(' ')



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
                Email = obj.Email,
                Station = obj.Station

                //NOTICE! -  possibly add rest of the propperties

            };
        }

        public override Model.Domain.Employee CreateDomainObjectFromPersistentDataObject(EmployeePersistentData pdObj)
        {
            return new Model.Domain.Employee
            (


                pdObj.Title,
                pdObj.Name,
                pdObj.Address,
                pdObj.PhoneNumber,
                pdObj.Email,
                pdObj.EmployeeNumber,
                pdObj.Station,
                pdObj.IsActive,
                pdObj.AccessLevel,
                pdObj.Username,
                pdObj.Password,
                pdObj.Key


            );
        }

    }
}
