using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.Models
{
    class Case_Personal_Info
    {
        public int id { get; set; }

        public string fullname { get; set; }
        public string guardian { get; set; }
        public string p_address { get; set; }
        public string c_address { get; set; }
        public string age { get; set; }
        public string contact { get; set; }
        public string aadhaar { get; set; }
        public string verifier { get; set; }
        public string secondary_verifier { get; set; }
        public byte[] picture { get; set; }
        public bool SMSCheckBox { get; set; }
     
        public string message { get; set; }

        //for update button

        public int caseKey { get; set; }

    }
}
