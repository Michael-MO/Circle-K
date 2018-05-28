using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Client.Annotations;
using Client.DataTransformations.Base;
using Client.Model.Domain;
using Client.ViewModel.Exceptions;

namespace Client.DataTransformations.ViewData
{
    public class EmployeeViewData : ViewDataAppBase, INotifyPropertyChanged
    {
        public int EmployeeNo { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
        
        public int PostalCode { get; set; }

        public string PhoneNo
        {
            get { return PhoneNo;}
            set
            {
                {
                    if (value != "")
                    {
                        if (value.Length > 8 || Regex.IsMatch(value, @"^[a-åA-Å]+$"))
                        {
                            ErrorHandeling.ErrorMessageField("Tlf. nummer skal indholde min. 8 tal og må ikke indeholde bogstaver.");
                            _popupactive = true;
                            OnPropertyChanged();
                        }
                        else
                        {
                            PhoneNo = value;
                            OnPropertyChanged();
                        }
                    }
                }
            }
        }

        public string Mail
        {
            get { return Mail;}
            set
            {
                if (value != "")
                {
                    if (Regex.IsMatch(value, @"@"))
                    {
                        ErrorHandeling.ErrorMessageField("En E-mail skal indeholde et @");
                        _popupactive = true;
                        OnPropertyChanged();
                    }
                    else
                    {
                        Mail = value;
                        OnPropertyChanged();
                    }
                }
            }
        }

        public List<Station> Station { get; set; }

        public bool IsActive { get; set; }

        public DateTime DeletionDate { get; set; }

        public string TerminationReason { get; set; }

        public string Cpr { get; set; }

        public int ImageKey { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

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
            UserName = "";
            UserPassword = "";
            _popupactive = false;
            // ImageKey = NullKey;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
