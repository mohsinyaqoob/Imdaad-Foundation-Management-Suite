using CharityManagementStudio.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityManagementStudio.Views
{
    public partial class FormMainProfile : Form
    {
        // Below two variables are to make the form movable
        private bool mouseDown;
        private Point lastLocation;


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

        public static FormStartScreenInfo startScreen;

        public FormMainProfile()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            startScreen = new FormStartScreenInfo();
            startScreen.MdiParent = this;
            startScreen.StartPosition = FormStartPosition.CenterScreen;
            startScreen.Show();
    }

        private void FormMainProfile_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FormMainProfile_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void FormMainProfile_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonMinimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
            //Below , I am redefining an Object of FormNewCase to null. So that next time after logout, it can open.
            developers = null;
            newCase = null;
            updateCase = null;
            viewAllCases = null; ;
            teamImdaad = null; ;
            donors = null;
            generateList = null; 
            messaging = null;
            backup = null;

            //Need to redefine all the form objects to null after logout button is hit.
            // Logic goes here


            MessageBox.Show("Successfully Logged Out!");
            FormAdminLogin adminLogin = new FormAdminLogin();
            adminLogin.Show();
        }
        public static FormNewCase newCase;
        private void ButtonNewCase_Click(object sender, EventArgs e)
        {
            updateCase = null;            
            viewAllCases = null;            
            teamImdaad = null;            
            generateList = null;
            messaging = null;
            donors = null;
            backup = null;

            if (newCase == null)
            {
                newCase = new FormNewCase();
                newCase.MdiParent = this;
                newCase.StartPosition = FormStartPosition.CenterScreen;
                newCase.Show();

            }
            else
            {
                newCase.Activate();
            }
        }

        private void PannelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void PannelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void PannelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        public static FormMessaging messaging;
        private void button9_Click(object sender, EventArgs e)
        {
            newCase = null;
            updateCase = null;
            viewAllCases = null;
            donors = null;
            generateList = null;
            teamImdaad = null;
            backup = null;
            startScreen = null;


            if (messaging == null)
            {
                messaging = new FormMessaging();
                messaging.MdiParent = this;
                messaging.StartPosition = FormStartPosition.CenterScreen;
                messaging.Show();
            }
            else
            {
                messaging.Activate();
            }
        }

        private void Pannel_Dashboard_Parent_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Pannel_Dashboard_Parent_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Pannel_Dashboard_Parent_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public static FormTeamImdaad teamImdaad;
        private void button3_Click(object sender, EventArgs e)
        {
            startScreen = null;
            newCase = null;
            updateCase = null;
            viewAllCases = null;            
            donors = null;
            generateList = null;
            messaging = null;
            backup = null;

            if (teamImdaad == null)
            {
                teamImdaad = new FormTeamImdaad();
                teamImdaad.MdiParent = this;
                teamImdaad.StartPosition = FormStartPosition.CenterScreen;
                teamImdaad.Show();

            }
            else
            {
                teamImdaad.Activate();
            }
        }
        public static FormViewAllCases viewAllCases;
        private void Button_ViewAllCases_Click(object sender, EventArgs e)
        {
            startScreen = null;
            newCase = null;
            updateCase = null;            
            teamImdaad = null;
            donors = null;
            messaging = null;
            generateList = null;
            backup = null;

            if (viewAllCases == null)
            {
                viewAllCases = new FormViewAllCases();
                viewAllCases.MdiParent = this;
                viewAllCases.StartPosition = FormStartPosition.CenterScreen;
                viewAllCases.Show();
            }
            else
            {
                viewAllCases.Activate();
            }
        }

        public static FormUpdateCase updateCase;
        private void button1_Click(object sender, EventArgs e)
        {
            startScreen = null;
            newCase = null;
            viewAllCases = null;
            teamImdaad = null;
            generateList = null;
            donors = null;
            messaging = null;
            backup = null;


            if (updateCase == null)
            {
                updateCase = new FormUpdateCase();
                updateCase.MdiParent = this;
                updateCase.StartPosition = FormStartPosition.CenterScreen;
                updateCase.Show();
            }
            else
            {
                updateCase.Activate();
            }
        }


        public static FormGenerateTransaction generateList;
        private void button4_Click(object sender, EventArgs e)
        {
            startScreen = null;
            newCase = null;
            updateCase = null;
            viewAllCases = null;
            donors = null;
            teamImdaad = null;            
            messaging = null;
            backup = null;

            if (generateList == null)
            {
                generateList = new FormGenerateTransaction();
                generateList.MdiParent = this;
                generateList.StartPosition = FormStartPosition.CenterScreen;
                generateList.Show();
            }
            else
            {
                generateList.Activate();
            }
        }


        public static FormDonors donors;
        private void button5_Click(object sender, EventArgs e)
        {
            startScreen = null;
            newCase = null;
            updateCase = null;
            viewAllCases = null;
            teamImdaad = null;
            generateList = null;
            messaging = null;
            backup = null;

            if (donors == null)
            {
                donors = new FormDonors();
                donors.MdiParent = this;
                donors.StartPosition = FormStartPosition.CenterScreen;
                donors.Show();
            }
            else
            {
                donors.Activate();
            }
        }

        public static FormDevelopersInfo developers;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            if(newCase!=null)
            {
                newCase.Close();
            }
            if (updateCase != null)
            {
                updateCase.Close();
            }
            if (viewAllCases != null)
            {
                viewAllCases.Close();
            }
            if (teamImdaad != null)
            {
                teamImdaad.Close();
            }
            if (donors != null)
            {
                donors.Close();
            }
            if (generateList != null)
            {
                generateList.Close();
            }
            if (messaging != null)
            {
                messaging.Close();
            }
            if (backup != null)
            {
                backup.Close();
            }

            //



            if (developers == null)
            {
                developers= new FormDevelopersInfo();
                developers.MdiParent = this;
                developers.StartPosition = FormStartPosition.CenterScreen;
                developers.Show();
            }
            else
            {
                developers.Activate();
            }
        }


        public static FormBackup backup;
        private void Button_BackupMainProfile_Click(object sender, EventArgs e)
        {
            startScreen = null;
            newCase = null;
            updateCase = null;
            viewAllCases = null;
            donors = null;
            generateList = null;
            teamImdaad = null;
            messaging = null;

            if (backup == null)
            {
                backup = new FormBackup();
                backup.MdiParent = this;
                backup.StartPosition = FormStartPosition.CenterScreen;
                backup.Show();
            }
            else
            {
                backup.Activate();
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            PicButton_Home.Cursor = Cursors.Hand;
        }

        private void PicButton_Home_Click(object sender, EventArgs e)
        {
            newCase = null;
            updateCase = null;
            viewAllCases = null;
            teamImdaad = null;
            donors = null;
            teamImdaad = null;
            messaging = null;
            backup = null;
            

            startScreen = new FormStartScreenInfo();
            startScreen.MdiParent = this;
            startScreen.StartPosition = FormStartPosition.CenterScreen;
            startScreen.Show();
        }
    }
}