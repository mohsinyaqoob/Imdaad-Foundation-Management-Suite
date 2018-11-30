using CharityManagementStudio.data;
using CharityManagementStudio.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmsClient;
using CharityManagementStudio.securities;

namespace CharityManagementStudio.controller
{
    class Charity_operations
    {
        static string con;
        public bool InsertData(registerAdmin admin)
        { 
            try
            {
                con = DbContext.ConnectDb();
                using (SqlConnection connect = new SqlConnection(con))
                {
                    string Query = "Insert into admins values ('" + admin.OrganizationName + "','" + admin.AdminId + "','" + admin.Password + "')";
                    SqlCommand com = new SqlCommand(Query, connect);
                    connect.Open();
                    com.ExecuteNonQuery();
                    admin.message = "User Registered Successfully";

                    //Hide the registration window
                    Views.FormRegisterAdmin raf = new Views.FormRegisterAdmin();
                    raf.Hide();
                    return true;
                }
            }
            catch(Exception e)
            {
                admin.message = "Something went wrong Or AdminID already Exists";
                return false;
            }
        }

        public bool validateEmpty(registerAdmin admin)
        {
            if (admin.OrganizationName != "")
            {
                if (admin.AdminId != "")
                {
                    if (admin.Password != "")
                    {
                        if (admin.confirmPassword != "")
                            return true;
                        else
                        {
                            admin.message = " Confirm Password is required";
                            return false;
                        }
                    }
                    else
                    {
                        admin.message = " Password is required";
                        return false;
                    }
                }
                else
                {
                    admin.message = " AdminID is required";
                    return false;
                }

            }
            else
            {
                admin.message = "Organisation name is required";
                return false;
            }


        }

        public bool validateChars(registerAdmin admin)
        {
            FormValidation valid = new FormValidation();

            

            if (valid.validateName(admin.OrganizationName))
            {
                if (valid.validateUsername(admin.AdminId))
                {
                    if (admin.Password == admin.confirmPassword)
                        return true;
                    else
                    {
                        admin.message = "Passwords do not match";
                        return false;
                    }
                }
                else
                {
                    admin.message = "Invalid Characters used for Admin ID";
                    return false;
                }
            }
            else
            {
                admin.message = "Invalid name format";
                return false;
            }
        }

        public bool Login(registerAdmin admin)
        {
            if (admin.AdminId == "" || admin.Password == "")
            {
                admin.message = "Credentails are Required";
                return false;
            }
            else
            {
                if (isAuth(admin))
                    return true;
                return false;
            }            
             
        }

        private bool isAuth(registerAdmin admin)
        {
            try
            {
                con = DbContext.ConnectDb();
                using (SqlConnection connect = new SqlConnection(con))
                {
                    string Query = "select count(*) from admins where username='"+admin.AdminId+"' and password='"+admin.Password+"';";
                    SqlCommand com = new SqlCommand(Query, connect);
                    connect.Open();
                    int count=(int)com.ExecuteScalar();
                   
                    if (count == 0)
                    {
                        admin.message = "Invalid Credentials";
                        return false;
                    }
                    else
                        return true;

                }
            }
            catch (Exception e)
            {
                admin.message = e.Message;
                return false;
            }
        }
    }
}
