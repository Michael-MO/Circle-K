using System;
using System.Collections.Generic;
using System.IO;
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

        public bool PopupActive
        {
            get { return DataObject._popupactive; }
            set
            {
                DataObject._popupactive = value;
                OnPropertyChanged();
            }
        }

        public int EmployeeNo
        {
            get { return DataObject.EmployeeNo; }
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

        public string Title
        {
            get { return DataObject.Title; }
            set
            {
                DataObject.Title = value;
                OnPropertyChanged();
            }
        }

        public int PostalCode
        {
            get { return DataObject.PostalCode; }
            set
            {
                DataObject.PostalCode = value;
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

        public string PhoneNo
        {
            get { return DataObject.PhoneNo; }
            set
            {
                if (value != null)
                {
                    if (value.Length > 8 || Regex.IsMatch(value, @"^[a-åA-Å]+$"))
                    {
                        ErrorHandeling.ErrorMessageField("Tlf. nummer skal indholde min. 8 tal og må ikke indeholde bogstaver.");
                        DataObject._popupactive = true;
                        OnPropertyChanged();
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
                if (value != default(string))
                {
                    if (Regex.IsMatch(value, @"@"))
                    {
                        ErrorHandeling.ErrorMessageField("En E-mail skal indeholde et @");
                        DataObject._popupactive = true;
                        OnPropertyChanged();
                    }
                    else
                    {
                        DataObject.Mail = value;
                        OnPropertyChanged();
                    }
                }
            }
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

        public bool IsActive
        {
            get { return DataObject.IsActive; }
            set
            {
                DataObject.IsActive = value;
                OnPropertyChanged();
            }
        }

        public DateTime DeletionDate
        {
            get { return DataObject.DeletionDate; }
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

        public string Cpr
        {
            get { return DataObject.Cpr; }
            set
            {
                DataObject.Cpr = value;
                OnPropertyChanged();
            }
        }

        public string UserName
        {
            get { return DataObject.UserName; }
            set
            {
                DataObject.UserName = value;
                OnPropertyChanged();
            }
        }

        public string UserPassword
        {
            get
            { return DataObject.UserPassword; }
            set
            {
                DataObject.UserPassword = value;
                OnPropertyChanged();
            }
        }

        public string AccessLevel
        {
            get { return DataObject.AccessLevel; }
            set
            {
                DataObject.AccessLevel = value;
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
