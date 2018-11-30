using CharityManagementStudio.controller;
using CharityManagementStudio.data;
using CharityManagementStudio.Models;
using CharityManagementStudio.SMS_Services;
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
    public partial class FormTeamImdaad : Form
    {
        public FormTeamImdaad()
        {
            InitializeComponent();
            loadTeamMembersGrid();
        }

        private void Button_AddTeam_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Label_ErrorMessage_TeamAdd.Text = "";

            AddTeamModel addTeamMd = new AddTeamModel();
            AddTeamController addTeamCt = new AddTeamController();

            addTeamMd.teamMemberName = Text_Team_Fullname.Text;
            addTeamMd.teamMemberAddress = Text_Team_Address.Text;
            addTeamMd.teamMemberContact = Text_Team_ContactNumber.Text;
            addTeamMd.sendSMSCheck = CheckBox_SendSMS_teamAdd.Checked;

            if (addTeamCt.saveTeamMember(addTeamMd))
            {
                if (addTeamCt.smsChecked(addTeamMd))
                {
                    NotifySMS sms = new NotifySMS();

                    if (sms.loginSMS())
                    {
                        if (sms.teamAddSMS(addTeamMd))
                        {
                            MessageBox.Show("Team Member was Notified Via SMS");
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

                Label_ErrorMessage_TeamAdd.Text = addTeamMd.errorMessage;
                clearFeilds();
                loadTeamMembersGrid();

                new FormNewCase();
                
            }
            else
            {
                Label_ErrorMessage_TeamAdd.Text = addTeamMd.errorMessage;
            }
        }

        private void Button_NewCaseClose_Click(object sender, EventArgs e)
        {
            if (FormMainProfile.teamImdaad != null)
                FormMainProfile.teamImdaad = null;
            this.Close();
        }

        private void Button_NewCaseClose1_Click(object sender, EventArgs e)
        {
            if (FormMainProfile.teamImdaad != null)
                FormMainProfile.teamImdaad = null;
            this.Close();
        }

        private void clearFeilds()
        {
            Text_Team_Fullname.Text = "";
            Text_Team_Address.Text = "";
            Text_Team_ContactNumber.Text = "";
        }

        private void loadTeamMembersGrid()
        {
            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {
                    Query = "Select name AS Name, address AS Address, contact AS 'Contact Number' from teamImdaad_tb ";
                    SqlDataAdapter dataadapter = new SqlDataAdapter(Query, con);
                    DataSet ds = new DataSet();
                    connect.Open();
                    dataadapter.Fill(ds, "teamImdaad_tb");
                    Grid_TeamImdaad.DataSource = ds;
                    Grid_TeamImdaad.DataMember = "teamImdaad_tb";
                }

            }
            catch (Exception e)
            {
                Label_ErrorMessage_TeamAdd.Text = e.Message;
            }
        }
    }
}
