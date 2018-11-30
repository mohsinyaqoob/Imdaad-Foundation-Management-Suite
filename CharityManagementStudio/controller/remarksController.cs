using CharityManagementStudio.data;
using CharityManagementStudio.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.controller
{
    class remarksController
    {
        private string connection;
        public remarksController()
        {
            this.connection = DbContext.ConnectDb();
        }

        public bool saveDetails(remarksModel remarksMd)
        {
            if(checkForEmpty(remarksMd))
                return true;
            return false;
        }






        public bool checkCaseType(int key)
        {
            string query="select count(*) from need_details where monthly > 0.00 and person_id = "+key;
            try
            {
                using (SqlConnection connect = new SqlConnection(this.connection))
                {
                    connect.Open();
                    SqlCommand com = new SqlCommand(query, connect);
                    int count=(int)com.ExecuteScalar();
                    if (count > 0)
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
        public bool insertData(remarksModel remarksMd)
        {
            if (!checkForEmpty(remarksMd))
            {
                return false;
            }
            else
            {
                string Query = "";
                try
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {

                        Query = "insert into remarks_tb values('" + remarksMd.startDate + "','" + remarksMd.endDate + "','" + remarksMd.comments + "','" + remarksMd.status + "','" + remarksMd.caseSelected + "');";
                        SqlCommand com = new SqlCommand(Query, connect);
                        connect.Open();
                        com.ExecuteNonQuery();

                        return true;
                    }
                }
                catch (Exception e)
                {
                    remarksMd.errorMessage = "Somthing went wrong555! Please try again";
                    return false;
                }
            }
        }





        public bool checkNeedetailsFilled(remarksModel remarksMd)
        {
            string query = "select count(*) from need_details where person_id = " + remarksMd.caseSelected;
            try
            {
                using (SqlConnection connect = new SqlConnection(this.connection))
                {
                    connect.Open();
                    SqlCommand com = new SqlCommand(query, connect);
                    int count = (int)com.ExecuteScalar();
                    if (count > 0)
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

        private bool checkForEmpty(remarksModel remarksMd)
        {
            if (remarksMd.comments != "")
            {
                return true;
            }
            else
            {
                remarksMd.errorMessage = "Comments Box cannot be left blank";
                return false;
            }
        }

        public bool IsAllreadyExisting(int key)
        {
            string Query = "";
            try
            {                
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    Query = "select count(*) from remarks_tb where person_id =" + key;
                    SqlCommand com = new SqlCommand(Query, connect);

                    connect.Open();
                    int count = (int)com.ExecuteScalar();
                    if (count != 0)
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

        
    }
}
