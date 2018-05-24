using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Model.Base;
using Client.Model.App;

namespace Client.Model.Domain
{
    public abstract class User : DomainAppBase
    {
        protected User(string accessLevel, string username, string password, int key) 
            : base(key)
        {
            AccessLevel = accessLevel;
            UserName = username;
            UserPassword = password;
        }

        public string AccessLevel { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }


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
