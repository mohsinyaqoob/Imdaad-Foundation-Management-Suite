using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.Models
{
    class Case_Family_info
    {
        public string familyMemberName { get; set; }
        public string familyMemberRelation { get; set; }
        public string familyMemberAge { get; set; }
        public string familyMemberEducation { get; set; }
        public string familyMemberMaritalStatus { get; set; }
        public string familyMemberOccupation { get; set; }
        public string familyMemberIncome { get; set; }
        public string familyMemberInfo_ErrorMessage { get; set; }
        public int familyMemberInfo_CaseSelected { get; set; }
    }
}
