using CharityManagementStudio.controller;
using CharityManagementStudio.Models;
using CharityManagementStudio.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityManagementStudio
{
    public partial class FormAdminLogin : Form
    {
        // Below two variables are to make the form movable
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

        public FormAdminLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        
        FormRegisterAdmin regForm;
        private void ButtonNewAdmin_Click(object sender, EventArgs e)
        {
            regForm = null;
            if (regForm == null)
            {
                regForm = new Views.FormRegisterAdmin();
                regForm.Show();
            }
            else
            {
                regForm.Activate();
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            regForm = null;


            Cursor.Current = Cursors.WaitCursor;

            registerAdmin admin = new registerAdmin();
            admin.AdminId = TextAdminId.Text;
            admin.Password = TextAdminPassword.Text;
            if (new Charity_operations().Login(admin))
            {
                FormMainProfile profile = new FormMainProfile();
                profile.Show();
                this.Hide();               
            }
            else
            {
                MessageBox.Show(admin.message);
                LabelErrorMessage.Text = admin.message;
            }
        }

        private void FormAdminLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FormAdminLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void FormAdminLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Close();
        }

        private void ButtonMinimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}