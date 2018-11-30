using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CharityManagementStudio.securities
{
    class Validate
    {
        private string NAME_PATTERN = @"^[a-zA-Z ]*$";
        private string CONTACT_PATTERN = @"^[0-9]{10,}$";
        private string AAD_PATTERN = @"^[0-9]{12}$";
        private string NUM_PATTERN = @"^[0-9]*$";
        private string ADDRESS_PATTERN = @"^(?=.*[a-zA-Z])(?=.*[0-9])*(?=.*[,.-])*.+$";
        private string EDU_PATTERN = @"^[a-zA-Z0-9 ]*$";

        public bool validateName(string name)
        {
            if(Regex.IsMatch(name,NAME_PATTERN))
                return true;
            return false;
        }

        public bool validateEducation(string name)
        {
            if (Regex.IsMatch(name, EDU_PATTERN))
                return true;
            return false;
        }

        public bool validateNumber(string num)
        {
            if (Regex.IsMatch(num, NUM_PATTERN))
                return true;
            return false;
        }

        public bool validateAadhaar(string num)
        {
            if (Regex.IsMatch(num, AAD_PATTERN))
                return true;
            return false;
        }

        public bool validateContact(string contact)
        {
            if (Regex.IsMatch(contact, CONTACT_PATTERN))
                return true;
            return false;
        }

        public bool validateAddress(string address)
        {
            if (Regex.IsMatch(address, ADDRESS_PATTERN))
                return true;
            return false;
        }
    }
}
