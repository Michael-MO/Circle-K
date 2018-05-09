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
        //Insancefields er redundant hvis de ikke bruges til noget.
        protected string _accessLevel;
        protected string _username;
        protected string _password;



        protected User(string accessLevel, string username, string password, int key) 
            : base(key)
        {
            _accessLevel = accessLevel;
            _username = username;
            _password = password;
        }

        public string AccessLevel
        {
            get { return _accessLevel; }
        }

        public string Username
        {
            get { return _username; }
        }

        public string Password
        {
            get { return _password; }
        }


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
