using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization.PhoneNumberFormatting;

namespace Client.Model.Domain
{
    public class Station
    {
        private string _phoneNumber;
        private string _stationNumber;
        private string _address;

        public Station(string phoneNumber, string stationNumber, string address)
        {
            _phoneNumber = phoneNumber;
            _stationNumber = stationNumber;
            _address = address;
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public string StationNumber
        {
            get { return _stationNumber; }
        }

        public string Address
        {
            get { return _address; }
        }

        public override string ToString()
        {
            return $"{PhoneNumber}";
        }





    }
}
