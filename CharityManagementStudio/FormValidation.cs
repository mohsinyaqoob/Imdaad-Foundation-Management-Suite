using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace CharityManagementStudio
{
    class FormValidation
    {
        public bool validateName(string val)
        {
            if(Regex.IsMatch(val,@"^[\sa-zA-Z]+$"))
                return true;
            return false;
        }

        public bool validateNumber(string val)
        {
            if (Regex.IsMatch(val, @"^[0-9]*$"))
                return true;
            return false;
        }

        public bool validateUsername(string val)
        {
            if(Regex.IsMatch(val, @"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$"))            
                return true;
            return false;
            
        }
    }
}
