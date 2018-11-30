using CharityManagementStudio.data;
using CharityManagementStudio.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.UpdateController
{
    class UpdateRemarksControl
    {
        string connection;
        public UpdateRemarksControl()
        {
            connection = DbContext.ConnectDb();
        }
        public remarksModel getRemarksDetails(int id)
        {
            string query = "select * from remarks_tb where person_id =" + id;
            remarksModel remarksMd = new remarksModel();
            try
            {
                using (SqlConnection connect = new SqlConnection(this.connection))
                {
                    connect.Open();
                    SqlCommand com = new SqlCommand(query, connect);
                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        remarksMd.startDate =reader["startDate"].ToString();
                        remarksMd.endDate = reader["endDate"].ToString();
                        remarksMd.comments = reader["comments"].ToString();
                        remarksMd.status = reader["status"].ToString();
                    }
                    return remarksMd;
                }
            }
            catch (Exception e)
            {
                remarksMd.errorMessage= e.Message;
                return remarksMd;
            }
        }

        public bool checkCaseType(int key)
        {
            string query = "select count(*) from need_details where monthly > 0.00 and person_id = " + key;
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
        public bool updateData(remarksModel remarksMd)
        {
            if (remarksMd.comments=="")
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

                        // Query = "insert into remarks_tb values('" + remarksMd.startDate + "','" + remarksMd.endDate + "','" + remarksMd.comments + "','" + remarksMd.status + "','" + remarksMd.caseSelected + "');";
                        Query = Query = "UPDATE remarks_tb SET startDate='" + remarksMd.startDate + "', endDate='" + remarksMd.endDate + "', comments='" + remarksMd.comments + "',status='" + remarksMd.status + "' WHERE person_id=" + remarksMd.caseSelected;
                        SqlCommand com = new SqlCommand(Query, connect);
                        connect.Open();
                        com.ExecuteNonQuery();

                        return true;
                    }
                }
                catch (Exception e)
                {
                    remarksMd.errorMessage = e.Message;
                   // remarksMd.errorMessage = "Somthing went wrong! Please try again";
                    return false;
                }
            }
        }
    }
}
