namespace CharityManagementStudio.Views
{
    partial class FormBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_BrowseRestoreLocation = new System.Windows.Forms.Button();
            this.Button_RestoreBackup = new System.Windows.Forms.Button();
            this.TextBox_RestoreLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Button_BrowseBackupLocation = new System.Windows.Forms.Button();
            this.Button_Backup = new System.Windows.Forms.Button();
            this.TextBox_BackupLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(994, 594);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup & Restore";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_BrowseRestoreLocation);
            this.groupBox1.Controls.Add(this.Button_RestoreBackup);
            this.groupBox1.Controls.Add(this.TextBox_RestoreLocation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(34, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 196);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restore";
            // 
            // Button_BrowseRestoreLocation
            // 
            this.Button_BrowseRestoreLocation.BackColor = System.Drawing.Color.Teal;
            this.Button_BrowseRestoreLocation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_BrowseRestoreLocation.FlatAppearance.BorderSize = 0;
            this.Button_BrowseRestoreLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_BrowseRestoreLocation.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold);
            this.Button_BrowseRestoreLocation.ForeColor = System.Drawing.Color.White;
            this.Button_BrowseRestoreLocation.Location = new System.Drawing.Point(720, 57);
            this.Button_BrowseRestoreLocation.Name = "Button_BrowseRestoreLocation";
            this.Button_BrowseRestoreLocation.Size = new System.Drawing.Size(93, 27);
            this.Button_BrowseRestoreLocation.TabIndex = 9;
            this.Button_BrowseRestoreLocation.Text = "Browse";
            this.Button_BrowseRestoreLocation.UseVisualStyleBackColor = false;
            this.Button_BrowseRestoreLocation.Click += new System.EventHandler(this.Button_BrowseRestoreLocation_Click);
            // 
            // Button_RestoreBackup
            // 
            this.Button_RestoreBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.Button_RestoreBackup.Enabled = false;
            this.Button_RestoreBackup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_RestoreBackup.FlatAppearance.BorderSize = 0;
            this.Button_RestoreBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RestoreBackup.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold);
            this.Button_RestoreBackup.ForeColor = System.Drawing.Color.White;
            this.Button_RestoreBackup.Location = new System.Drawing.Point(720, 105);
            this.Button_RestoreBackup.Name = "Button_RestoreBackup";
            this.Button_RestoreBackup.Size = new System.Drawing.Size(93, 27);
            this.Button_RestoreBackup.TabIndex = 9;
            this.Button_RestoreBackup.Text = "Restore";
            this.Button_RestoreBackup.UseVisualStyleBackColor = false;
            this.Button_RestoreBackup.Click += new System.EventHandler(this.Button_RestoreBackup_Click);
            // 
            // TextBox_RestoreLocation
            // 
            this.TextBox_RestoreLocation.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextBox_RestoreLocation.Location = new System.Drawing.Point(238, 62);
            this.TextBox_RestoreLocation.Name = "TextBox_RestoreLocation";
            this.TextBox_RestoreLocation.Size = new System.Drawing.Size(446, 24);
            this.TextBox_RestoreLocation.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(95, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Restore Location";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Button_BrowseBackupLocation);
            this.groupBox4.Controls.Add(this.Button_Backup);
            this.groupBox4.Controls.Add(this.TextBox_BackupLocation);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(34, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(905, 196);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Backup";
            // 
            // Button_BrowseBackupLocation
            // 
            this.Button_BrowseBackupLocation.BackColor = System.Drawing.Color.Teal;
            this.Button_BrowseBackupLocation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_BrowseBackupLocation.FlatAppearance.BorderSize = 0;
            this.Button_BrowseBackupLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_BrowseBackupLocation.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold);
            this.Button_BrowseBackupLocation.ForeColor = System.Drawing.Color.White;
            this.Button_BrowseBackupLocation.Location = new System.Drawing.Point(720, 61);
            this.Button_BrowseBackupLocation.Name = "Button_BrowseBackupLocation";
            this.Button_BrowseBackupLocation.Size = new System.Drawing.Size(93, 27);
            this.Button_BrowseBackupLocation.TabIndex = 9;
            this.Button_BrowseBackupLocation.Text = "Browse";
            this.Button_BrowseBackupLocation.UseVisualStyleBackColor = false;
            this.Button_BrowseBackupLocation.Click += new System.EventHandler(this.Button_BrowseBackupLocation_Click);
            // 
            // Button_Backup
            // 
            this.Button_Backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.Button_Backup.Enabled = false;
            this.Button_Backup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_Backup.FlatAppearance.BorderSize = 0;
            this.Button_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Backup.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold);
            this.Button_Backup.ForeColor = System.Drawing.Color.White;
            this.Button_Backup.Location = new System.Drawing.Point(720, 109);
            this.Button_Backup.Name = "Button_Backup";
            this.Button_Backup.Size = new System.Drawing.Size(93, 27);
            this.Button_Backup.TabIndex = 9;
            this.Button_Backup.Text = "Backup";
            this.Button_Backup.UseVisualStyleBackColor = false;
            this.Button_Backup.Click += new System.EventHandler(this.Button_Backup_Click);
            // 
            // TextBox_BackupLocation
            // 
            this.TextBox_BackupLocation.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextBox_BackupLocation.Location = new System.Drawing.Point(238, 62);
            this.TextBox_BackupLocation.Name = "TextBox_BackupLocation";
            this.TextBox_BackupLocation.Size = new System.Drawing.Size(446, 24);
            this.TextBox_BackupLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(95, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Backup Location";
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 598);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBackup";
            this.Text = "FormBackup";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Button_BrowseBackupLocation;
        private System.Windows.Forms.TextBox TextBox_BackupLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Backup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_BrowseRestoreLocation;
        private System.Windows.Forms.Button Button_RestoreBackup;
        private System.Windows.Forms.TextBox TextBox_RestoreLocation;
        private System.Windows.Forms.Label label2;
    }
}