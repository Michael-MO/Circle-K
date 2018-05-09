using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataTransformations.ViewData;
using Client.ViewModel.Base;

namespace Client.ViewModel.Data
{
    class EmployeeDetailsViewModel : DataViewModelAppBase<EmployeeViewData>
    {
        public EmployeeDetailsViewModel(EmployeeViewData obj) : base(obj, "Employees")
        {
        }

        public string Name
        {
            get { return DataObject.Name; }
            set
            {
                DataObject.Name = value;
                OnPropertyChanged();
            }
        }

        public string Adress
        {
            get { return DataObject.Address; }
            set
            {
                DataObject.Address = value;
                OnPropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get { return DataObject.PhoneNumber; }
            set
            {
                DataObject.PhoneNumber = value;
                OnPropertyChanged();
            }
        }

        public string EMail
        {
            get { return DataObject.Email; }
            set
            {
                DataObject.Email = value;
                OnPropertyChanged();
            }
        }


        public int EmployeeNumber
        {
            get { return DataObject.EmployeeNumber; }
        }

        public string Station
        {
            get { return DataObject.Station; }
            set
            {
                DataObject.Station = value;
                OnPropertyChanged();
            }
        }

        public override int ImageKey
        {
            get { return DataObject.ImageKey; }
            set
            {
                DataObject.ImageKey = value;
                OnPropertyChanged();
            }
        }

    }
}
