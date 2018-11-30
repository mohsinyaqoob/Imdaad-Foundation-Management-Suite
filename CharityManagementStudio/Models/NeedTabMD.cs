using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.Models
{
    class NeedTabMD
    {
        public int caseSelectedIndex { get; set; }

        public bool monthlyChecked { get; set; }
        public bool medicalChecked { get; set; }
        public bool marriageChecked { get; set; }
        public bool employChecked { get; set; }
        public bool OneTimeChecked { get; set; }
        public bool otherChecked { get; set; }    
        
        public string monthlyAmount { get; set; }
        public string medicalAmount { get; set; }
        public string marriageAmount { get; set; }
        public string employmentAmount { get; set; }
        public string oneTimeAmount { get; set; }
        public string otherAmount { get; set; }

        public string errorMessage { get; set; }
    }
}
