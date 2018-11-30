namespace CharityManagementStudio.Views
{
    partial class FormTeamImdaad
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Grid_TeamImdaad = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Button_AddTeam = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CheckBox_SendSMS_teamAdd = new System.Windows.Forms.CheckBox();
            this.Label_ErrorMessage_TeamAdd = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Text_Team_ContactNumber = new System.Windows.Forms.TextBox();
            this.Text_Team_Address = new System.Windows.Forms.TextBox();
            this.Text_Team_Fullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TeamImdaad)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(988, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Team Member";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Grid_TeamImdaad);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox2.Location = new System.Drawing.Point(15, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(956, 504);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Team Imdaad";
            // 
            // Grid_TeamImdaad
            // 
            this.Grid_TeamImdaad.AllowUserToAddRows = false;
            this.Grid_TeamImdaad.AllowUserToDeleteRows = false;
            this.Grid_TeamImdaad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_TeamImdaad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_TeamImdaad.BackgroundColor = System.Drawing.Color.White;
            this.Grid_TeamImdaad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_TeamImdaad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_TeamImdaad.Location = new System.Drawing.Point(9, 22);
            this.Grid_TeamImdaad.Name = "Grid_TeamImdaad";
            this.Grid_TeamImdaad.Size = new System.Drawing.Size(937, 475);
            this.Grid_TeamImdaad.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Button_AddTeam);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Team Member";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Button_AddTeam
            // 
            this.Button_AddTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.Button_AddTeam.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_AddTeam.FlatAppearance.BorderSize = 0;
            this.Button_AddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddTeam.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold);
            this.Button_AddTeam.ForeColor = System.Drawing.Color.White;
            this.Button_AddTeam.Location = new System.Drawing.Point(447, 459);
            this.Button_AddTeam.Name = "Button_AddTeam";
            this.Button_AddTeam.Size = new System.Drawing.Size(93, 27);
            this.Button_AddTeam.TabIndex = 9;
            this.Button_AddTeam.Text = "Save";
            this.Button_AddTeam.UseVisualStyleBackColor = false;
            this.Button_AddTeam.Click += new System.EventHandler(this.Button_AddTeam_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CheckBox_SendSMS_teamAdd);
            this.groupBox4.Controls.Add(this.Label_ErrorMessage_TeamAdd);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.Text_Team_ContactNumber);
            this.groupBox4.Controls.Add(this.Text_Team_Address);
            this.groupBox4.Controls.Add(this.Text_Team_Fullname);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(34, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(920, 340);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Member Info";
            // 
            // CheckBox_SendSMS_teamAdd
            // 
            this.CheckBox_SendSMS_teamAdd.AutoSize = true;
            this.CheckBox_SendSMS_teamAdd.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_SendSMS_teamAdd.Location = new System.Drawing.Point(630, 215);
            this.CheckBox_SendSMS_teamAdd.Name = "CheckBox_SendSMS_teamAdd";
            this.CheckBox_SendSMS_teamAdd.Size = new System.Drawing.Size(81, 20);
            this.CheckBox_SendSMS_teamAdd.TabIndex = 42;
            this.CheckBox_SendSMS_teamAdd.Text = "Send SMS";
            this.CheckBox_SendSMS_teamAdd.UseVisualStyleBackColor = true;
            // 
            // Label_ErrorMessage_TeamAdd
            // 
            this.Label_ErrorMessage_TeamAdd.AutoSize = true;
            this.Label_ErrorMessage_TeamAdd.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.Label_ErrorMessage_TeamAdd.ForeColor = System.Drawing.Color.Red;
            this.Label_ErrorMessage_TeamAdd.Location = new System.Drawing.Point(338, 275);
            this.Label_ErrorMessage_TeamAdd.Name = "Label_ErrorMessage_TeamAdd";
            this.Label_ErrorMessage_TeamAdd.Size = new System.Drawing.Size(0, 15);
            this.Label_ErrorMessage_TeamAdd.TabIndex = 37;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.Teal;
            this.label30.Location = new System.Drawing.Point(143, 76);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(195, 15);
            this.label30.TabIndex = 34;
            this.label30.Text = "Feilds marked with * are mandatory";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(216, 131);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 21);
            this.label23.TabIndex = 33;
            this.label23.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(261, 211);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 21);
            this.label22.TabIndex = 32;
            this.label22.Text = "*";
            // 
            // Text_Team_ContactNumber
            // 
            this.Text_Team_ContactNumber.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Text_Team_ContactNumber.Location = new System.Drawing.Point(341, 206);
            this.Text_Team_ContactNumber.Name = "Text_Team_ContactNumber";
            this.Text_Team_ContactNumber.Size = new System.Drawing.Size(197, 24);
            this.Text_Team_ContactNumber.TabIndex = 5;
            // 
            // Text_Team_Address
            // 
            this.Text_Team_Address.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Text_Team_Address.Location = new System.Drawing.Point(341, 166);
            this.Text_Team_Address.Name = "Text_Team_Address";
            this.Text_Team_Address.Size = new System.Drawing.Size(370, 24);
            this.Text_Team_Address.TabIndex = 4;
            // 
            // Text_Team_Fullname
            // 
            this.Text_Team_Fullname.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Text_Team_Fullname.Location = new System.Drawing.Point(341, 127);
            this.Text_Team_Fullname.Name = "Text_Team_Fullname";
            this.Text_Team_Fullname.Size = new System.Drawing.Size(370, 24);
            this.Text_Team_Fullname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(143, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(143, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(143, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Full Name";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(2, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(996, 595);
            this.tabControl.TabIndex = 1;
            // 
            // FormTeamImdaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 598);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTeamImdaad";
            this.Text = "FormTeamImdaad";
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TeamImdaad)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Grid_TeamImdaad;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Button_AddTeam;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Label_ErrorMessage_TeamAdd;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Text_Team_ContactNumber;
        private System.Windows.Forms.TextBox Text_Team_Address;
        private System.Windows.Forms.TextBox Text_Team_Fullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.CheckBox CheckBox_SendSMS_teamAdd;
    }
}