using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.Models
{
    class remarksModel
    {
        public string startDate { get; set; }

        public string endDate { get; set; }

        public string comments { get; set; }

        public string status { get; set; }

        public string errorMessage { get; set; }

        public int caseSelected { get; set; }
    }
}
