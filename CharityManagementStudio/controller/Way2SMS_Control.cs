using CharityManagementStudio.data;
using CharityManagementStudio.Models;
using CharityManagementStudio.securities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CharityManagementStudio.controller
{
    class Way2SMS_Control
    {
        string connection;
        public Way2SMS_Control()
        {
            connection = DbContext.ConnectDb();
        }

        public bool updateLogin(Way2SMS_Model smsModel)
        {
            if (checkForEmpty(smsModel))
            {
                insertCredentials(smsModel);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool insertCredentials(Way2SMS_Model smsModel)
        {
            string cs = DbContext.ConnectDb();

            try 
            {
                string query = "update smsCredentials_tb set user_number = '"+smsModel.user_number+"',user_password = '"+smsModel.user_password+"' where id = 1";

                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand com = new SqlCommand(query,con);
                    con.Open();
                    com.ExecuteNonQuery();

                    return true;
                }
            }
            catch(Exception ex)
            {
                smsModel.errorMessage = "Somthing Went Wrong! Please try Again";
                return false;
            }




        }

        private bool checkForEmpty(Way2SMS_Model smsModel)
        {
            if (smsModel.user_number == "" || smsModel.user_password == "")
            {
                smsModel.errorMessage="Username or Password cannot be Empty";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateChars(Way2SMS_Model smsModel)
        {
            Validate vd=new Validate();

            if (vd.validateNumber(smsModel.user_number))
            {
                if (vd.validateAddress(smsModel.user_password))
                {
                    return true;
                }
                else
                {
                    smsModel.errorMessage = "Invalid Password";
                    return false;
                }
            }
            else
            {
                smsModel.errorMessage = "Invalid Mobile Number";
                return false;
            }
        }

        public Way2SMS_Model getSmsCredentials(int id)
        {
            String query = "Select * from smsCredentials_tb where id=" + id;
            Way2SMS_Model smsModel = new Way2SMS_Model();

            try
            {
                using (SqlConnection connect = new SqlConnection(this.connection))
                {
                    connect.Open();
                    SqlCommand com = new SqlCommand(query, connect);
                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        smsModel.user_number = reader["user_number"].ToString();
                        smsModel.user_password = reader["user_password"].ToString();
                    }
                    return smsModel;
                }

            }
            catch (Exception e)
            {
                smsModel.errorMessage = e.Message;
                return smsModel;
            }
        }
    }
}
