using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Client.DataTransformations.ViewData;
using Client.Model.Domain;
using Client.ViewModel.Base;
using Client.ViewModel.Exceptions;

namespace Client.ViewModel.Data
{
    public class EmployeeDataViewModel : DataViewModelAppBase<EmployeeViewData>
    {


        public EmployeeDataViewModel(EmployeeViewData obj) : base(obj, "Employees")
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
            get { return DataObject.PhoneNo; }
            set
            {
                if (value != default(string))
                {
                    if (value.Length > 8 || Regex.IsMatch(value, @"^[a-åA-Å]+$"))
                    {
                        InvalidFieldException ex = new InvalidFieldException();
                        throw ex;
                    }
                    else
                    {
                        DataObject.PhoneNo = value;
                        OnPropertyChanged();
                    }
                }
            }
        }

        public string EMail
        {
            get { return DataObject.Mail; }
            set
            {
                DataObject.Mail = value;
                OnPropertyChanged();
            }
        }


        public int EmployeeNumber
        {
            get { return DataObject.EmployeeNo; }
        }

        public List<Station> Station
        {
            get { return DataObject.Station; }
            set
            {
                DataObject.Station = value;
                OnPropertyChanged();
            }
        }

        public DateTime DeletionDate
        {
            get { return DataObject.DeletionDate; }
            set
            {
                DataObject.DeletionDate = value;
                OnPropertyChanged();
            }
        }

        public string TerminationReason
        {
            get { return DataObject.TerminationReason; }
            set
            {
                DataObject.TerminationReason = value;
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

        public string Password
        {
            get
            { return DataObject.Password; }
            set
            {
                DataObject.Password = value;
                OnPropertyChanged();
            }
        }

        public string Username
        {
            get { return DataObject.Username; }
            set
            {
                DataObject.Username = value;
                OnPropertyChanged();
            }
        }

    }
}
