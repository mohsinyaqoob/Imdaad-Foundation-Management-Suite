using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.Models
{
    class Case_Bank_Details
    {
        public string bankName { get; set; }
        public string bankBranch { get; set; }
        public string bankIfsc { get; set; }
        public string bankAccountNumber { get; set; }
        public string bankAccountHolderName { get; set; }
        public string bankAccountType { get; set; }
        public string bankErrorMessage { get; set; }
        public int bank_caseSelected { get; set; }
    }
}
