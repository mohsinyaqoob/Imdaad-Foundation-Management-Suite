using CharityManagementStudio.data;
using CharityManagementStudio.Models;
using CharityManagementStudio.securities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.controller
{
    class MessagingController
    {
        public bool checkForEmpty(MessagingModel singleSmsMd)
        {
            if (singleSmsMd.recipient != "")
            {
                if (singleSmsMd.smsText != "")
                {
                    if(validateTextFeilds(singleSmsMd))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    singleSmsMd.errorMessage = "*The SMS Cannot be Blank!";
                    return false;
                }
            }
            else
            {
                singleSmsMd.errorMessage = "*Recipient Cannot be Blank";
                return false;
            }
        }

        private bool validateTextFeilds(MessagingModel singleSmsMd)
        {
            Validate vd = new Validate();
            if (vd.validateNumber(singleSmsMd.recipient))
            {
                return true;
            }
            else
            {
                singleSmsMd.errorMessage = "Invalid Recipient";
                return false;
            }
        }
    }
}
