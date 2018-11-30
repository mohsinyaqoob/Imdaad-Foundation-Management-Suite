using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmsClient;
using Nitin.Sms.Api;
using CharityManagementStudio.Models;
using CharityManagementStudio.data;
using System.Data.SqlClient;

namespace CharityManagementStudio.SMS_Services
{
    class NotifySMS
    {
        Way2Sms wts;
        string connection;
        Sms_Credentils_Model smsCreMd = new Sms_Credentils_Model();

        string username, password;

        public NotifySMS()
        {
            connection = DbContext.ConnectDb();

            smsCreMd = getSmsCredentials();
            this.username = smsCreMd.user_number;
            this.password = smsCreMd.user_password;

        }

        private Sms_Credentils_Model getSmsCredentials()
        {
            String query = "Select * from smsCredentials_tb where id=1";
            Sms_Credentils_Model creModel = new Sms_Credentils_Model();
            try
            {
                using (SqlConnection connect = new SqlConnection(this.connection))
                {
                    connect.Open();
                    SqlCommand com = new SqlCommand(query, connect);
                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        creModel.user_number = reader["user_number"].ToString();
                        creModel.user_password = reader["user_password"].ToString();
                    }
                    return creModel;
                }

            }
            catch (Exception e)
            {
                creModel.errorMessage = e.Message;
                return creModel;
            }
        }

        public bool loginSMS()
        {
            try
            {
                wts = new Way2Sms(username, password);
                if(wts.Login())
                    return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool notifyViaSMS(Case_Personal_Info case_new)
        {
            string caseMessage = "You have been registered at Imdaad Foundation. You will be notified about Acceptence or Rejection once verification is complete.\nCoordinator Imdaad Foundation.";
            string verifierMessage = "You have a new Case to Verify at " + case_new.c_address + ". Your verification partner is "+case_new.secondary_verifier+". Please get in touch for more information.\nCoordinator, Imdaad Foundation";            

            bool status1 = wts.SendSms(case_new.contact, caseMessage);//send to applicant
            bool status2 = wts.SendSms(case_new.verifier.ToString(), verifierMessage);//send to verifier
            bool status_secondary_verifier = wts.SendSms(case_new.secondary_verifier,verifierMessage);

            if (!status1 && !status2)
            {
                return false;              
            }
            else
            {
                return true;
            }
        }
        
        public bool teamAddSMS(AddTeamModel addTeamMd)
        {
            string teamAddMessage = "Greetings Dear "+addTeamMd.teamMemberName+". You have been successfully added to Imdaad Foundation Suite 1.0. Thank you for being part of Imdaad Foundation.";
            try
            {
                bool status3 = wts.SendSms(addTeamMd.teamMemberContact, teamAddMessage);
                if (status3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                return false;
            }            
        }

        public bool donorAddSMS(DonorMD donorModel)
        {
            string donorMessage = "Greetings "+donorModel.DonorName+". Thank you for donating to Imdaad Foundation. We promise to use your donation in the most effective way possible.\n-Coordinator Imdaad Foundation-";
            try
            {
                bool status4 = wts.SendSms(donorModel.DonorContact, donorMessage);
                if (status4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool singleSMS(MessagingModel singleSmsMd)
        {
            string singleMessage=singleSmsMd.smsText;
            string singleRecipient = singleSmsMd.recipient;

            try
            {
                bool status5 = wts.SendSms(singleRecipient,singleMessage);
                if (status5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
