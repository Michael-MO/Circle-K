using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.UI.Popups;
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
        private int postalCode;
        private string cpr;
        private bool isActiveButton = true;
        
        public int EmployeeNo { get; set; }

        public string Title { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    if (Regex.IsMatch(value.Replace(" ", ""), "^[a-zøæå A-ZØÆÅ]+$"))
                    {
                        name = value;
                        IsActiveButton = true;
                        OnPropertyChanged();
                    }
                    else
                    {
                        IsActiveButton = false;
                        MessageDialog md = new MessageDialog("Navne må ikke indeholde tal eller special tegn");
                        md.ShowAsync();
                    }
                }
            }
        }

        public string Address { get; set; }

        public int PostalCode
        {
            get { return postalCode;}
            set
            {
                if (value.ToString().Length == 4)
                {
                    postalCode = value;
                    IsActiveButton = true;
                    OnPropertyChanged();
                }
                else
                {
                    IsActiveButton = false;
                    MessageDialog md = new MessageDialog("Et Post nummer skal være 4 cifre langt.");
                    md.ShowAsync();
                }

            }
        }

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
                        long parsedValue;
                        string tempHold = value;
                        if (Regex.IsMatch(value, "[+]"))
                        {
                            value = value.Substring(3);
                            value = value.Replace(" " , "");
                        }

                        if (value.Length >= 8 && value.Length <= 12 && long.TryParse(value, out parsedValue))
                        {
                            phoneNo = tempHold;
                            IsActiveButton = true;
                            OnPropertyChanged();
                        }
                        else
                        {
                            IsActiveButton = false;
                            MessageDialog md = new MessageDialog("Tlf. nummer skal indholde mellem 8 og 12 tegn og må ikke indeholde bogstaver.");
                            md.ShowAsync();
                        }

                        //    {

                        //    }

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
                        IsActiveButton = true;
                        OnPropertyChanged();
                    }
                    else
                    {
                        IsActiveButton = false;
                        MessageDialog md = new MessageDialog("En E-mail skal indeholde et @");
                        md.ShowAsync();

                    }
                }
            }
        }

        public List<Station> Station { get; set; }

        public bool IsActive { get; set; }

        public DateTime DeletionDate { get; set; }

        public string TerminationReason { get; set; }

        public string Cpr
        {
            get { return cpr;}
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    string temphold = value;
                    long praseinto;

                    if (value.Contains('-'))
                    {
                       value = value.Replace("-", "");
                    }

                    if (value.Length >= 10 && value.Length <= 12 && long.TryParse(value, out praseinto))
                    {
                        cpr = temphold;
                        IsActiveButton = true;
                        OnPropertyChanged();
                    }
                    else
                    {
                        IsActiveButton = false;
                        MessageDialog md = new MessageDialog("Et Cpr skal indeholde din fødselsdag og de sidste 4 control cifre.");
                        md.ShowAsync();
                    }
                }

            }

        }

        public int ImageKey { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public string AccessLevel { get; set; }

        public bool IsActiveButton
        {
            get { return isActiveButton; }
            set
            {
                isActiveButton = value;
                OnPropertyChanged();
            }
        }

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
