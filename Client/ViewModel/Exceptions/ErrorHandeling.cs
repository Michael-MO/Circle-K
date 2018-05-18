using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Client.DataTransformations.ViewData;
using Client.ViewModel.Data;

namespace Client.ViewModel.Exceptions
{
    public class ErrorHandeling
    {

        public string _errormessage;

        public void code()
        {
            
            EmployeeViewData emp = null;

            try
            {
                
            }
            catch (InvalidFieldException ex)
            {
                _errormessage = ($"Et mobil nummer skal være min. 8 tal langt og må ikke indholde bukstaver");
            }
        }

    }

}
