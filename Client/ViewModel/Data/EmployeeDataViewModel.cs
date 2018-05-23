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

        public string DeletionDate
        {
            get { return DataObject.DeletionDate.ToString("dd/MM/yyyy"); }
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
