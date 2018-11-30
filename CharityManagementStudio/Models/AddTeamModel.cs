using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.Models
{
    class AddTeamModel
    {
        public int id { get; set; }
        public string teamMemberName { get; set; }
        public string teamMemberAddress { get; set; }
        public string teamMemberContact { get; set; }
        public string errorMessage { get; set; }
        public bool sendSMSCheck { get; set; }
    }
}
