using System;

namespace Client.Models
{
    public class City
    {
        public int PostalCode { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}, {PostalCode}";
        }
    }
}
