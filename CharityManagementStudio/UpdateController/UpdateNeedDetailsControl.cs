using CharityManagementStudio.data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.UpdateController
{
    class UpdateNeedDetailsControl
    {
        public bool NeedDetailsFilled(int key)
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
                        return false;
                    else
                        return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
