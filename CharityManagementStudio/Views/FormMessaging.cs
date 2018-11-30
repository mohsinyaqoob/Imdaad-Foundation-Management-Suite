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
    //E:\UpdateCharityManagementStudio\CharityManagementStudio\controller\case_Control.cs
    public partial class FormMessaging : Form
    {
        string connection;
        Way2SMS_Model smsModel = new Way2SMS_Model();
        Way2SMS_Control smsControl = new Way2SMS_Control();
        

        public FormMessaging()
        {
            InitializeComponent();
            connection = DbContext.ConnectDb();
            getCredentials(1);
            
        }

        private void getCredentials(int id)
        {
            smsModel = smsControl.getSmsCredentials(id);
            TextBox_way2smsUserNum.Text = smsModel.user_number;
            TextBox_way2smsPassword.Text = smsModel.user_password;
        }

        private void Button_SendSingleMessage_Click(object sender, EventArgs e)
        {
            Label_ErrorSingleSMS.Text = "";

            MessagingController singleSmsCt = new MessagingController();
            MessagingModel singleSmsMd = new MessagingModel();

            singleSmsMd.recipient=TextBox_SingleReciepient.Text;
            singleSmsMd.smsText = RichText_SingleMessage.Text;

            if (singleSmsCt.checkForEmpty(singleSmsMd))
            {
                NotifySMS sms = new NotifySMS();
                if(sms.loginSMS())
                {
                    if (sms.singleSMS(singleSmsMd))
                    {
                        MessageBox.Show("SMS has been sent");
                        clearSingelSMSFeilds();
                    }
                    else
                    {
                        MessageBox.Show("SMS Not Sent. Somthing went wrong!");
                    }
                }
                else
                {
                    MessageBox.Show("SMS Login Failed");
                }
            }
            else
            {
                Label_ErrorSingleSMS.Text = singleSmsMd.errorMessage;
            }
        }

        private void clearSingelSMSFeilds()
        {
            TextBox_SingleReciepient.Text = "";
            RichText_SingleMessage.Text = "";
        }

        private void Button_ChangeLogin_Click(object sender, EventArgs e)
        {
            Label_ErrorWaySMS.Text = "";

            smsModel.user_number = TextBox_way2smsUserNum.Text;
            smsModel.user_password = TextBox_way2smsPassword.Text;
            
            if (smsControl.updateLogin(smsModel))
            {
                MessageBox.Show("Successfully Updated the Login Credentials","Success",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("The Mobile number you provided is either not registered on Way2SMS or there was somthing wrong with Upating. Please Try Again","Mobile Number Updation Failed",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
        
    }
}
