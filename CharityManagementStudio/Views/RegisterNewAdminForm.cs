using CharityManagementStudio.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CharityManagementStudio.Models;
using CharityManagementStudio.controller;

namespace CharityManagementStudio.Views
{
    public partial class RegisterNewAdminForm : Form
    {
        public RegisterNewAdminForm()
        {
            InitializeComponent();
        }

       
        private void ButtonRegisterAdmin_Click(object sender, EventArgs e)
        {
            registerAdmin admin= collectDetails();
            Charity_operations control = new Charity_operations();
            
            if (control.validateEmpty(admin))
            {
                if (control.validateChars(admin))
                {
                    control.InsertData(admin);
                    MessageBox.Show(admin.message);                    

                }
                else
                    MessageBox.Show(admin.message);
            }
            else
            {
                MessageBox.Show(admin.message);
            }
        }

        private registerAdmin collectDetails()
        {
            registerAdmin admin = new registerAdmin();
            admin.OrganizationName = TextOrganizationName.Text;
            admin.AdminId = TextAdministratorID.Text;
            admin.Password = TextPassword.Text;
            admin.confirmPassword = TextConfirmPassword.Text;

            return admin;
        }
    }
}
