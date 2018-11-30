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
    class AddTeamController
    {
        Validate valid = new Validate();

        private bool checkForEmpty(AddTeamModel addTeamMd)
        {
            if(addTeamMd.teamMemberName=="" || addTeamMd.teamMemberContact == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool saveTeamMember(AddTeamModel addTeamMd)
        {
            if (checkForEmpty(addTeamMd))
            {
                if (validateChars(addTeamMd))
                {
                    if(!memberNotExisting(addTeamMd))
                    {
                        if (insertData(addTeamMd))
                        {
                            addTeamMd.errorMessage = "Successfully Saved the data";
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        addTeamMd.errorMessage = "A Team Member with this contact number allready exists";
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                addTeamMd.errorMessage = "Please fill all the feilds marked with *";
                return false;
            }
        }

        private bool validateChars(AddTeamModel addTeamMd)
        {
            if (valid.validateName(addTeamMd.teamMemberName))
            {
                if (valid.validateContact(addTeamMd.teamMemberContact))
                {
                    //insert
                    return true;
                }
                else
                {
                    addTeamMd.errorMessage = "*Please Enter a 10 digit valid contact number";
                    return false;
                }
            }
            else
            {
                addTeamMd.errorMessage = "*Invalid Name format";
                return false;
            }
        }

        private bool insertData(AddTeamModel addTeamMd)
        {
            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {

                    Query = "insert into teamImdaad_tb values('" + addTeamMd.teamMemberName + "','" + addTeamMd.teamMemberAddress + "','" + addTeamMd.teamMemberContact +"');";
                    SqlCommand com = new SqlCommand(Query, connect);
                    connect.Open();
                    com.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception e)
            {
                addTeamMd.errorMessage = "Somthing went wrong! Please try again";
                return false;
            }
        }

        private bool memberNotExisting(AddTeamModel addTeamMd)
        {
            try
            {
                string con = DbContext.ConnectDb();
                using (SqlConnection connect = new SqlConnection(con))
                {
                    string Query1 = "select COUNT(*) from teamImdaad_tb where contact='" + addTeamMd.teamMemberContact + "'";
                    SqlCommand com = new SqlCommand(Query1, connect);
                    connect.Open();
                    int result = (int)com.ExecuteScalar();
                    if (result != 0)
                        return true;
                    else
                        return false;
                }

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool smsChecked(AddTeamModel addTeamMd)
        {
            if (addTeamMd.sendSMSCheck)
                return true;
            return false;
        }


        public List<AddTeamModel> getTeam()
        {
            List<AddTeamModel> cases = new List<AddTeamModel>();
            try
            {
                string con = DbContext.ConnectDb();
                using (SqlConnection connect = new SqlConnection(con))
                {
                    string Query1 = "select * from teamImdaad_tb";
                    SqlCommand com = new SqlCommand(Query1, connect);
                    connect.Open();
                    SqlDataReader rdr = com.ExecuteReader();
                    AddTeamModel mycase = null;
                    while (rdr.Read())
                    {
                        mycase = new AddTeamModel();
                        mycase.id = (int)rdr["id"];
                        mycase.teamMemberName = (string)rdr["name"];
                        mycase.teamMemberAddress = (string)rdr["address"];
                        mycase.teamMemberContact = (string)rdr["contact"];
                     
                        cases.Add(mycase);
                    }
                    rdr = null;
                    return cases;
                }

            }
            catch (Exception e)
            {
                return cases;

            }
        }
    }
}
