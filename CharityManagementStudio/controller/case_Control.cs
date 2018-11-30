using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharityManagementStudio.Models;
using CharityManagementStudio.securities;
using CharityManagementStudio.data;
using System.Data.SqlClient;
using SmsClient;
using Nitin.Sms.Api;
using System.IO;


namespace CharityManagementStudio.controller
{
    class case_Control
    {
        public static string con;
        public static int LastCaseID=0;


        public bool checkForEmpty(Case_Personal_Info case_new)
        {
            if (case_new.fullname == "" || case_new.p_address == "" || case_new.c_address == "" || case_new.contact == "")
            {
                case_new.message = "*Please fill all the feilds marked with *";
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateForChars(Case_Personal_Info case_new)
        {
            Validate valid = new Validate();
            if (valid.validateName(case_new.fullname))
            {
                if (valid.validateName(case_new.guardian))
                {
                    if (valid.validateAddress(case_new.p_address) && valid.validateAddress(case_new.c_address))
                    {
                        if (valid.validateContact(case_new.contact))
                        {
                            if (valid.validateNumber(case_new.age))
                            {
                                if (valid.validateAadhaar(case_new.aadhaar) || case_new.aadhaar == "")
                                {
                                    if (!chekContactNumberExists(case_new))
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                       case_new.message = "*Contact Number already exists";
                                        return false;
                                    }
                                }
                                else
                                {
                                    case_new.message = "*Invalid Aadhaar Number";
                                    return false;
                                }
                            }
                            else
                            {
                                case_new.message = "*Age must be a number";
                                return false;
                            }

                        }
                        else
                        {
                            case_new.message = "*Invalid Contact number format";
                            return false;
                        }
                    }
                    else
                    {
                        case_new.message = "*Invalid Address format";
                        return false;
                    }
                }
                else
                {
                    case_new.message = "*Invalid Guardian name format";
                    return false;
                }
            }
            else
            {
                case_new.message = "*Invalid name format";
                return false;
            }
        }

        public bool chekContactNumberExists(Case_Personal_Info case_new)
        {
            try
            {
                con = DbContext.ConnectDb();
                using (SqlConnection connect = new SqlConnection(con))
                {
                    string Query1 = "select COUNT(*) from personal_info where contact_no='" + case_new.contact + "'";
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

        public bool InsertPersonalInf(Case_Personal_Info case_new)
        {
            string Query = "";
            try
            {
                con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {
                    connect.Open();
                    if (case_new.age == "")
                        case_new.age = "0";
                    Query = "insert into personal_info values('"+case_new.fullname+"','" + case_new.guardian + "','" + case_new.p_address + "','" + case_new.c_address + "','" + case_new.contact + "','" + case_new.aadhaar + "'," + case_new.age + ",'" + case_new.verifier + "','" + case_new.secondary_verifier + "',@picture);";
                    SqlCommand com = new SqlCommand(Query, connect);
                    com.Parameters.AddWithValue("picture", case_new.picture);
                    com.ExecuteNonQuery();
                    
                    string Query1 = "select id as lastid from personal_info where id=@@IDENTITY;";
                    com = new SqlCommand(Query1, connect);
                    LastCaseID = (int)com.ExecuteScalar();
                    return true;
                }
            }
            catch (Exception e)
            {
                case_new.message = e.Message;
                return false;
            }
        }

        public List<Case_Personal_Info> getAllCases()
        {
            List<Case_Personal_Info> cases=new List<Case_Personal_Info>();
            try
            {
                con = DbContext.ConnectDb();
                using (SqlConnection connect = new SqlConnection(con))
                {
                    string Query1 = "select * from personal_info";
                    SqlCommand com = new SqlCommand(Query1, connect);
                    connect.Open();
                    SqlDataReader rdr=com.ExecuteReader();
                    Case_Personal_Info mycase=null;
                    while (rdr.Read())
                    {
                         mycase = new Case_Personal_Info();
                        mycase.id =(int)rdr["id"];
                        mycase.fullname =(string)rdr["fullname"];
                        mycase.guardian = (string)rdr["guardian"];
                        mycase.p_address = (string)rdr["p_address"];
                        mycase.c_address = (string)rdr["c_address"];
                        mycase.contact = (string)rdr["contact_no"];
                        mycase.aadhaar = (string)rdr["aadhaar"];
                
                        mycase.age = rdr["age"].ToString();
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

        public bool smsChecked(Case_Personal_Info case_new)
        {

            if (case_new.SMSCheckBox)            
                return true;
            return false;
            
        }

        //public bool insertPhotoPath()
        //{
                
        //}

        public int getLastId()
        {
            try
            {
                con = DbContext.ConnectDb();
                string Query = "select id as lastid from personal_info where id=@@IDENTITY;";

                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand com = new SqlCommand(Query, connect);
                    LastCaseID = (int)com.ExecuteScalar();
                    return LastCaseID;
                }

            }
            catch (Exception e)
            {
                return LastCaseID;
            }
        }
    }
}
