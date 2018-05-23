using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel.Exceptions
{
    class InvalidFieldException : Exception
    {
        public InvalidFieldException()
        {
            
        }

        public InvalidFieldException(string message) : base(message)
        {
            
        }
    }
}
