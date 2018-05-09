using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Domain
{
    public abstract class User
    {
        protected string _userName;
        protected string _userPassword;
        protected string _accessLevel;

        protected User(string userName, string userPassword, string accessLevel)
        {
            _userName = userName;
            _userPassword = userPassword;
            _accessLevel = accessLevel;
        }

        public string AccessLevel
        {
            get { return _accessLevel; }
        }

        public string UserName
        {
            get { return _userName; }
        }

        public string UserPassword
        {
            get { return _userPassword; }
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
