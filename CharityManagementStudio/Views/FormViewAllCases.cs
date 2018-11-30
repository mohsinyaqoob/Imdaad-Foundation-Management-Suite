using CharityManagementStudio.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using CharityManagementStudio.Pdf_Printing;

namespace CharityManagementStudio.Views
{
    public partial class FormViewAllCases : Form
    {
        ProcessQueries queries = new ProcessQueries();

        public FormViewAllCases()
        {
            InitializeComponent();

            ComboBox_ViewCasesSort.SelectedIndex = 0;

            loadGrid_Cases(queries.AllCases);

            
        }
        public void loadGrid_Cases(string Query)
        {
            try
            {
                string con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlDataAdapter dataadapter = new SqlDataAdapter(Query, con);
                    DataSet ds = new DataSet();
                    connect.Open();
                    dataadapter.Fill(ds, "personal_info");
                    Remarks_DataGrid.DataSource = ds;
                    Remarks_DataGrid.DataMember = "personal_info";
                }

            }
            catch (Exception e)
            {
                //Label_ErrorMessage_TeamAdd.Text = e.Message;
                MessageBox.Show(e.Message);
            }
        }
            
        private void ComboBox_ReasonForApproaching_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if(ComboBox_ViewCasesSort.SelectedIndex == 0)
            {
                loadGrid_Cases(queries.AllCases);
            }
            else if (ComboBox_ViewCasesSort.SelectedIndex == 1)
            {
                loadGrid_Cases(queries.OnlyMonthly);
            }   
            else if(ComboBox_ViewCasesSort.SelectedIndex == 2)
            {
                loadGrid_Cases(queries.OnlyMedical);
            }
            else if(ComboBox_ViewCasesSort.SelectedIndex == 3)
            {
                loadGrid_Cases(queries.OnlyMarriage);
            }
            else if(ComboBox_ViewCasesSort.SelectedIndex == 4)
            {
                loadGrid_Cases(queries.OnlyEmploymentAssistance);
            }
            else if(ComboBox_ViewCasesSort.SelectedIndex == 5)
            {
                loadGrid_Cases(queries.OnlyOneTimeCases);
            }
            else if(ComboBox_ViewCasesSort.SelectedIndex == 6)
            {
                loadGrid_Cases(queries.OnlyOtherFundingCases);
            }
            else if (ComboBox_ViewCasesSort.SelectedIndex == 7)
            {
                loadGrid_Cases(queries.AllRejectedCases);
            }
            else if (ComboBox_ViewCasesSort.SelectedIndex == 8)
            {
                loadGrid_Cases(queries.AllVerifiedCases);
            }
            else if (ComboBox_ViewCasesSort.SelectedIndex == 9)
            {
                loadGrid_Cases(queries.AllPendingCases);
            }
            else
            {
                loadGrid_Cases(queries.All_including_incomplete);
            }
        }
        
        private void Button_ExportAllCasesToPDF_Click(object sender, EventArgs e)
        {
            ExportToPdf pdfExport = new ExportToPdf();

            pdfExport.ExportPDFDocument(Remarks_DataGrid);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Only those cases are visible whose complete Details have been filled in the 'New Tab'.","Possible Reason",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
