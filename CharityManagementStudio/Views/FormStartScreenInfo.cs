using CharityManagementStudio.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityManagementStudio.Views
{
    public partial class FormStartScreenInfo : Form
    {
        float monthlyTotal, medicalTotal, EmploymentTotal, MarriageTotal,OneTimeTotal,OtherTotal;
        public FormStartScreenInfo()
        {
            InitializeComponent();
            string queryPending = "select count(*) from remarks_tb WHERE status='Pending'";
            string queryVerified = "select count(*) from remarks_tb WHERE status='Verified'";
            string queryRejected = "select count(*) from remarks_tb WHERE status='Rejected'";
            string queryTotalCases = "select count(*) from personal_info";

            Label_PendingCases.Text = getStatusCount(queryPending).ToString();
            Label_VerifiedCases.Text = getStatusCount(queryVerified).ToString();
            Label_RejectedCases.Text = getStatusCount(queryRejected).ToString();
            Label_TotalCases.Text = getStatusCount(queryTotalCases).ToString();
            
            Label_incompleteCases.Text = (Convert.ToInt32(Label_TotalCases.Text) - (Convert.ToInt32(Label_PendingCases.Text) + Convert.ToInt32(Label_VerifiedCases.Text) + Convert.ToInt32(Label_RejectedCases.Text))).ToString();

            this.Table_CaseStatsStartPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table_CaseStatsStartPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));                    
        }
        
        int count = 0;
        private int getStatusCount(string query)
        {
            string con = DbContext.ConnectDb();
            

            try
            {
                using(SqlConnection connect =new SqlConnection(con))
                {
                    SqlCommand com = new SqlCommand(query, connect);
                    connect.Open();
                    count = (int)com.ExecuteScalar();
                    return count;
                }
            }
            catch (Exception ex)
            {
                return count;
            }
        }
    }
}
