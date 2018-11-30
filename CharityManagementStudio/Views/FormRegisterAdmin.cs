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
using System.Threading;
using System.Runtime.InteropServices;

namespace CharityManagementStudio.Views
{
    public partial class FormRegisterAdmin : Form
    {
        //below two variables are to make the form movable, logic follows in functions
        private bool mouseDown;
        private Point lastLocation;


        //The below function is to give this form a shadow effect
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        //This is for rounded corners of this MDI PArent Form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect, // x-coordinate of upper-left corner
                int nTopRect, // y-coordinate of upper-left corner
                int nRightRect, // x-coordinate of lower-right corner
                int nBottomRect, // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
            );


        public FormRegisterAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonMinimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            registerAdmin admin = collectDetails();
            Charity_operations control = new Charity_operations();

            if (control.validateEmpty(admin))
            {
                if (control.validateChars(admin))
                {
                    if (control.InsertData(admin))
                    {
                        MessageBox.Show("Success! Try Loggin in Now", "Admin Registered");
                        this.Close();
                    }
                    else
                    {
                        LabelErrorMessage.Text = admin.message;
                    }
                    
                }
                else
                    LabelErrorMessage.Text = admin.message;
            }
            else
            {
                LabelErrorMessage.Text = admin.message;
            }
        }

        private void FormRegisterAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FormRegisterAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void FormRegisterAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}