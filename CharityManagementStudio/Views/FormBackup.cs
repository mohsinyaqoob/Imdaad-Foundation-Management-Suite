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

namespace CharityManagementStudio.Views
{
    public partial class FormBackup : Form
    {
        SqlConnection con;
        public FormBackup()
        {
            InitializeComponent();
            con= new SqlConnection(DbContext.ConnectDb());
            getDbName();
        }

        private void Button_BrowseBackupLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TextBox_BackupLocation.Text = dlg.SelectedPath;
                Button_Backup.Enabled = true;
            }
        }

        private void Button_Backup_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (TextBox_BackupLocation.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Backup File Location","",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + dbName + "] TO DISK='" + TextBox_BackupLocation.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Backed up Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        Button_Backup.Enabled = false;
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Somthing went wrong. Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void Button_BrowseRestoreLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database Restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TextBox_RestoreLocation.Text = dlg.FileName;
                Button_RestoreBackup.Enabled = true;
            }
        }

        private void Button_RestoreBackup_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string sqlStmt2 = string.Format("ALTER DATABASE [" + dbName + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + dbName + "] FROM DISK='" + TextBox_RestoreLocation.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + dbName + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                bu4.ExecuteNonQuery();

                MessageBox.Show("Data Restored Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing went wrong. Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        string dbName;
        private bool getDbName()
        {
            try
            {
                string query = "SELECT DB_NAME()";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand com = new SqlCommand(query, con);
                dbName = (string)com.ExecuteScalar();

                return true;
            }

            catch (Exception ex)
            {
                return false;
                MessageBox.Show("Somthing went wrong. Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
