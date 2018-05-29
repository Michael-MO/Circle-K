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
        private string phoneNo;
        private string mail;
        private string name;

        public int EmployeeNo { get; set; }

        public string Title { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    if (Regex.IsMatch(value, "^[a-åA-Å0-9]+$") || Regex.IsMatch(value, "^[0-9]+$"))
                    {
                        //ErrorHandeling.ErrorMessageField("Navne må ikke indeholde tal");
                        _nameError = "Navne må ikke indeholde tal eller special tegn";
                        OnPropertyChanged();
                        OnPropertyChanged(_nameError);
                    }
                    else
                    {
                        name = value;
                        _nameError = "";
                        OnPropertyChanged();
                    }
                }
            }
        }

        public string Address { get; set; }

        public int PostalCode { get; set; }

        public string PhoneNo
        {
            get
            {
                return phoneNo;
            }
            set
            {
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        int parsedValue;
                        string tempHold = value;
                        if (Regex.IsMatch(value, "[+]"))
                        {
                            value = value.Trim(new char[]{'+'});
                            value = value.Replace(" " , "");
                        }

                        if (value.Length >= 8 && int.TryParse(value, out parsedValue))
                        {
                            phoneNo = tempHold;
                            _phoneError = "";
                            OnPropertyChanged();
                        }
                        else
                        {
                            _phoneError = "Tlf. nummer skal indholde min. 8 tal og må ikke indeholde bogstaver.";
                            OnPropertyChanged();

                        }
                    }
                }
            }
        }

        public string Mail
        {
            get { return mail; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (Regex.IsMatch(value, "@"))
                    {
                        mail = value;
                        _mailError = "";
                        OnPropertyChanged();
                    }
                    else
                    {
                        //ErrorHandeling.ErrorMessageField("En E-mail skal indeholde et @");
                        //OnPropertyChanged(nameof(ErrorHandeling.ErrorMessageField));

                        _mailError = "En E-mail skal indeholde et @";
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

        public string _phoneError { get; set; }

        public string _mailError { get; set;}

        public string _nameError { get; set; }





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
            _phoneError = "";
            _mailError = "";
            _nameError = "";
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
