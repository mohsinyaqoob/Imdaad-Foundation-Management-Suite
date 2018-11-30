using CharityManagementStudio.data;
using CharityManagementStudio.Models;
using CharityManagementStudio.securities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.UpdateController
{
    class UpdatePersonalControl
    {
        private string connection;
        public string error;
        public UpdatePersonalControl()
        {
            this.connection = DbContext.ConnectDb();
        }

        public Case_Personal_Info getPersonalData(int id)
        {
            String query = "Select * from personal_info where id=" + id;
            Case_Personal_Info person = new Case_Personal_Info();
            try
            {
                using (SqlConnection connect = new SqlConnection(this.connection))
                {
                    connect.Open();
                    SqlCommand com = new SqlCommand(query, connect);
                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        person.fullname = reader["fullname"].ToString();
                        person.guardian = reader["guardian"].ToString();
                        person.p_address = reader["p_address"].ToString();
                        person.c_address = reader["c_address"].ToString();
                        person.age = reader["age"].ToString();
                        person.contact = reader["contact_no"].ToString();
                        person.aadhaar = reader["aadhaar"].ToString();
                        person.picture = (byte[])reader["image"];
                        //person.verifier = reader["verifier"].ToString();
                    }
                    return person;
                }

            }
            catch (Exception e)
            {
                person.message = e.Message;
                return person;
            }
        }

        public bool updateDetails(Case_Personal_Info personalModel)
        {
            if (checkForEmpty(personalModel))
            {
                if (checkForChars(personalModel))
                {
                    if (insertData(personalModel))
                    {
                        personalModel.message = "Details Upated Successfully!";
                        return true;
                    }
                    else
                    {
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
                return false;
            }
        }

        private bool checkForEmpty(Case_Personal_Info personalModel)
        {
            if (personalModel.fullname == "" || personalModel.p_address == "" || personalModel.c_address == "" || personalModel.contact == "")
            {
                personalModel.message = "Feilds marked with * cannot be left blank";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkForChars(Case_Personal_Info personalModel)
        {
            Validate valid = new Validate();

            if (valid.validateName(personalModel.fullname))
            {
                if (valid.validateName(personalModel.guardian))
                {
                    if (valid.validateAddress(personalModel.p_address) && valid.validateAddress(personalModel.c_address))
                    {
                        if (valid.validateContact(personalModel.contact))
                        {
                            if (valid.validateNumber(personalModel.age))
                            {
                                if (valid.validateAadhaar(personalModel.aadhaar) || personalModel.aadhaar == "")
                                {
                                    return true;
                                }
                                else
                                {
                                    personalModel.message = "*Invalid Aadhaar Number";
                                    return false;
                                }
                            }
                            else
                            {
                                personalModel.message = "*Age must be a number";
                                return false;
                            }

                        }
                        else
                        {
                            personalModel.message = "*Invalid Contact number format";
                            return false;
                        }
                    }
                    else
                    {
                        personalModel.message = "*Invalid Address format";
                        return false;
                    }
                }
                else
                {
                    personalModel.message = "*Invalid Guardian name format";
                    return false;
                }
            }
            else
            {
                personalModel.message = "*Invalid name format";
                return false;
            }
        }

        private bool contactNumberAllreadyExists(Case_Personal_Info personalModel)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    string Query1 = "select COUNT(*) from personal_info where contact_no='" + personalModel.contact + "'";
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

        private bool insertData(Case_Personal_Info personalModel)
        {
            string Query = "";
            try
            {

                using (SqlConnection connect = new SqlConnection(connection))
                {
                    if (personalModel.age == "")
                        personalModel.age = "0";
                    Query = "UPDATE personal_info SET fullname='" + personalModel.fullname + "', guardian='" + personalModel.guardian + "', p_address='" + personalModel.p_address + "',c_address='" + personalModel.c_address + "',contact_no='" + personalModel.contact + "',aadhaar='" + personalModel.aadhaar + "',age='" + personalModel.age + "',image=@picture WHERE id=" + personalModel.caseKey;

                    SqlCommand com = new SqlCommand(Query, connect);
                    com.Parameters.AddWithValue("picture", personalModel.picture);


                    connect.Open();
                    com.ExecuteNonQuery();

                    //string Query1 = "select id as lastid from personal_info where id=@@IDENTITY;";
                    //com = new SqlCommand(Query1, connect);
                    //LastCaseID = (int)com.ExecuteScalar();
                    return true;
                }

            }
            catch (Exception e)
            {
                personalModel.message = e.Message;
                return false;
            }
        }

        public void deleteEntireCase(int key)
        {
            SqlConnection connect = new SqlConnection(connection);
            connect.Open();
            SqlTransaction transact = connect.BeginTransaction();
            try
            {
                new SqlCommand("Delete from remarks_tb where person_id=" + key, connect, transact).ExecuteNonQuery();
                new SqlCommand("Delete from need_details where person_id=" + key, connect, transact).ExecuteNonQuery();
                new SqlCommand("Delete from other_case_details where person_id=" + key, connect, transact).ExecuteNonQuery();
                new SqlCommand("Delete from bank_tb where person_id=" + key, connect, transact).ExecuteNonQuery();
                new SqlCommand("Delete from family_tb where person_id=" + key, connect, transact).ExecuteNonQuery();
                new SqlCommand("Delete from personal_info where id=" + key, connect, transact).ExecuteNonQuery();
                transact.Commit();
                error = "Case Deleted Successfully";
            }
            catch (Exception e)
            {
                transact.Rollback();
                //error = e.Message;
                error = "Somethig Went Wrong. PLease try again";
            }
            finally
            {
                connect.Close();
            }
        }
    }
}

 
