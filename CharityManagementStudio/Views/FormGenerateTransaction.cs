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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using CharityManagementStudio.Pdf_Printing;

namespace CharityManagementStudio.Views
{
    public partial class FormGenerateTransaction : Form
    {
        string connection;
        public FormGenerateTransaction()
        {
            InitializeComponent();
            // Generate List from DataBase
            connection = DbContext.ConnectDb();
            loadMonthlyCases();
        }

        private void loadMonthlyCases()
        {
            string Query = "";
            try
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    Query = "select Name, Bank, [Account Number], Amount from monthly_view_enddate";
                    //Query = "select * from monthly_view_enddate";
                    //In this query we need Account Holder Name, Bank Account and Bank Branch and Monthly amount.                  
                    
                    SqlDataAdapter dataadapter = new SqlDataAdapter(Query, connection );
                    DataSet ds = new DataSet();
                    connect.Open();
                    dataadapter.Fill(ds, "need_details");
                    Grid_GenerateTransaction.DataSource = ds;
                    Grid_GenerateTransaction.DataMember = "need_details";
                    //Grid_GenerateTransaction.Columns["person_id"].Visible = false;
                }

            }
            catch (Exception ex)
            {
                //Label_ErrorMessage_TeamAdd.Text = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_PrintGenerateTransaction_Click(object sender, EventArgs e)
        {
            ExportToPdf exportPdf = new ExportToPdf();
            exportPdf.ExportPDFDocument(Grid_GenerateTransaction);
        }
    }
}
