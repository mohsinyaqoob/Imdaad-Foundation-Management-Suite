using CharityManagementStudio.controller;
using CharityManagementStudio.data;
using CharityManagementStudio.Models;
using CharityManagementStudio.Pdf_Printing;
using CharityManagementStudio.SMS_Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityManagementStudio.Views
{
    public partial class FormDonors : Form
    {
        string connection;
        public FormDonors()
        {
            InitializeComponent();

            Date_DonationDate.MinDate = new DateTime(2017, 1, 1);


            connection = DbContext.ConnectDb();
            loadDonors();
        }

        private void loadDonors()
        {
            string Query = "";
            try
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    Query = "SELECT name AS Name, donor_address AS Address, contact AS Contact, donation_amount AS Amount, donation_date AS 'Donation Date' from donors_tb";
                    //In this query we need Account Holder Name, Bank Account and Bank Branch and Monthly amount.                  

                    SqlDataAdapter dataadapter = new SqlDataAdapter(Query, connection);
                    DataSet ds = new DataSet();
                    connect.Open();
                    dataadapter.Fill(ds, "donors_tb");
                    Grid_ViewDonors.DataSource = ds;
                    Grid_ViewDonors.DataMember = "donors_tb";
                }

            }
            catch (Exception e)
            {
                //Label_ErrorMessage_TeamAdd.Text = e.Message;
                MessageBox.Show(e.Message);
                //MessageBox.Show("Somthing went wrong. Please try again!");
            }
        }
        private void Button_AddDonor_Click(object sender, EventArgs e)
        {
            Label_ErrorDonation.Text = "";

            DonorMD donorModel = new DonorMD();
            DonorCT DonorControl = new DonorCT();

            donorModel.DonorName = TextBox_DonorName.Text;
            donorModel.DonorGuardian = TextBox_DonorGuardian.Text;
            donorModel.DonorAddress = TextBox_DonorAddress.Text;
            donorModel.DonorContact = TextBox_DonorContact.Text;
            donorModel.DonationAmount = TextBox_DonationAmount.Text;
            donorModel.DonationDate = Date_DonationDate.Text;
            donorModel.smsChecked = CheckBox_SendSMS_Donor.Checked;            

            if (DonorControl.SaveDonorDetails(donorModel))
            {
                if (DonorControl.smsChecked(donorModel))
                {
                    NotifySMS sms = new NotifySMS();

                    if (sms.loginSMS())
                    {
                        if (sms.donorAddSMS(donorModel))
                        {
                            MessageBox.Show("Team Donor was Notified Via SMS");
                        }
                        else
                        {
                            MessageBox.Show("The Member was not notified via SMS", "Somthing Went Wrong");
                        }
                    }
                    else
                    {
                        MessageBox.Show("SMS Not Sent", "The Login Failed");
                    }
                }

                MessageBox.Show("Donation Recorded Successfully!");
                loadDonors();
                clearFeilds();
            }
            else
            {
                Label_ErrorDonation.Text = donorModel.ErrorMessageDonors;
            }
        }

        private void clearFeilds()
        {
            TextBox_DonorName.Text = "";
            TextBox_DonorGuardian.Text = "";
            TextBox_DonorAddress.Text = "";
            TextBox_DonorContact.Text = "";
            TextBox_DonationAmount.Text = "";
            Date_DonationDate.Value = DateTime.Now;
            CheckBox_SendSMS_Donor.Checked = false;
        }

        private void Button_PrintDonors_Click(object sender, EventArgs e)
        {
            ExportToPdf pdf = new ExportToPdf();
            pdf.ExportPDFDocument(Grid_ViewDonors);
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";
            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
    }
}