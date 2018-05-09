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
        public Station(string stationNo, string phoneNo, string address)
        {
            StationNo = stationNo;
            PhoneNo = phoneNo;
            Address = address;
        }

        public string StationNo { get; set; }

        public string PhoneNo { get; set; }

        public string Address { get; set; }
    }
}
