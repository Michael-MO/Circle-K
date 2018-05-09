using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Domain
{
    public abstract class User
    {
        protected User(string username, string password, string accessLevel)
        {
            Username = username;
            Password = password;
            AccessLevel = accessLevel;
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string AccessLevel { get; set; }


        // Method for setting accesslevel
        // Minimum Butikschef eller højere
        // Kan kun give adgangsniveau lavere end ens eget niveau
        // Gøres ved at man ændre "title" i employee classen, som så ændre accessLevel her
        // Se Daniel billede på telefon

        protected void ChangeAccesslevel(Employee employee, string accessLevel)
        {

        }


        // Method for setting username



        // Method for setting password


    }
}
