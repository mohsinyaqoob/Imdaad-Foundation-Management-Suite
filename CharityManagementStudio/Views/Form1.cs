using CharityManagementStudio.controller;
using CharityManagementStudio.Models;
using CharityManagementStudio.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityManagementStudio
{
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void ButtonNewAdmin_Click(object sender, EventArgs e)
        {
            Views.RegisterNewAdminForm raf = new Views.RegisterNewAdminForm();
            raf.Show();            
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            registerAdmin admin = new registerAdmin();
            admin.AdminId = TextAdminId.Text;
            admin.Password = TextAdminPassword.Text;
            if (new Charity_operations().Login(admin))
            {
                // Validation Success, Redirecting to MainScreen                
                MainScreen mainScr = new MainScreen();                
                mainScr.Show();
                this.Hide();
                
            }
            else
                MessageBox.Show(admin.message);
        }
    }
}
