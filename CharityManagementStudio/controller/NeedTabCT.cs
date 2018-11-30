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
    class NeedTabCT
    {
        Validate valid = new Validate();
        string connection;
        public NeedTabCT()
        {
            this.connection = DbContext.ConnectDb();
        }

        public bool caseSelected(NeedTabMD needMd)
        {
            if (needMd.caseSelectedIndex != 0)
            {
                return true;
            }
            else
            {                
                return false;
            }
        }

        public bool saveNeedDetails(NeedTabMD needMd)
        {
            if(AllreadyNotExisting(needMd.caseSelectedIndex))
            {
                if (validateForEmpty(needMd))
                {
                    if (insertNeedData(needMd))
                    {
                        needMd.errorMessage = "Details Saved Successfully!";
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
                needMd.errorMessage = "Details allready exist for this case";
                return false;
            }
        }

        private bool validateForEmpty(NeedTabMD needMd)
        {
            if (needMd.monthlyChecked || needMd.medicalChecked || needMd.marriageChecked || needMd.employChecked || needMd.OneTimeChecked || needMd.otherChecked)
            {
                if (needMd.monthlyChecked)
                {
                    if (needMd.monthlyAmount == "")
                    {
                        needMd.errorMessage = "Enter Monthly Assistance amount";
                        return false;
                    }
                }

                if (needMd.medicalChecked)
                {
                    if (needMd.medicalAmount == "")
                    {
                        needMd.errorMessage = "Enter Medical Assistance amount";
                        return false;
                    }

                }

                if (needMd.marriageChecked)
                {
                    if (needMd.marriageAmount == "")
                    {
                        needMd.errorMessage = "Enter Marriage Assistance amount";
                        return false;
                    }

                }

                if (needMd.employChecked)
                {
                    if (needMd.employmentAmount == "")
                    {
                        needMd.errorMessage = "Enter Employment Assistence amount";
                        return false;
                    }

                }

                if (needMd.OneTimeChecked)
                {
                    if (needMd.oneTimeAmount == "")
                    {
                        needMd.errorMessage = "Enter One-Time Rehabilitation amount";
                        return false;
                    }

                }

                if (needMd.otherChecked)
                {
                    if (needMd.otherAmount == "")
                    {
                        needMd.errorMessage = "Enter Other amount";
                        return false;
                    }

                }
                return true;
            }
            else
            {
                needMd.errorMessage = "Please select atleast one option above";
                return false;
            }
        }

        private bool insertNeedData(NeedTabMD needMd)
        {
            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {

                    Query = "insert into need_details values('"+needMd.monthlyAmount+"','"+needMd.medicalAmount+"','"+needMd.marriageAmount+"','" +needMd.employmentAmount+ "','" +needMd.oneTimeAmount+ "','" +needMd.otherAmount+ "','"+ needMd.caseSelectedIndex+"');";
                    SqlCommand com = new SqlCommand(Query, connect);
                    connect.Open();
                    com.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception e)
            {
                needMd.errorMessage = "Somthing Went Wrong or invalid characters used. Please Try Again!";
                return false;
            }
        }

        private bool AllreadyNotExisting(int key)
        {
            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();
                using (SqlConnection connect = new SqlConnection(con))
                {
                    Query = "select count(*) from need_details where person_id =" + key;
                    SqlCommand com = new SqlCommand(Query, connect);

                    connect.Open();
                    int count = (int)com.ExecuteScalar();
                    if (count == 0)
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

        public bool BankDetailsAdded(NeedTabMD needMd)
        {
            string query = "select count(*) from bank_tb where person_id = " + needMd.caseSelectedIndex;
            try
            {
                using (SqlConnection connect = new SqlConnection(this.connection))
                {
                    connect.Open();
                    SqlCommand com = new SqlCommand(query, connect);
                    int count = (int)com.ExecuteScalar();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        needMd.errorMessage = "Since the Case is Monthly. Please fill the Bank Details for this Case.";
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
