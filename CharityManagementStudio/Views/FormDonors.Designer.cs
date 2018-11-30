namespace CharityManagementStudio.Views
{
    partial class FormDonors
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CheckBox_SendSMS_Donor = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Date_DonationDate = new System.Windows.Forms.DateTimePicker();
            this.TextBox_DonationAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_AddDonor = new System.Windows.Forms.Button();
            this.Label_ErrorDonation = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TextBox_DonorContact = new System.Windows.Forms.TextBox();
            this.TextBox_DonorAddress = new System.Windows.Forms.TextBox();
            this.TextBox_DonorGuardian = new System.Windows.Forms.TextBox();
            this.TextBox_DonorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Button_PrintDonors = new System.Windows.Forms.Button();
            this.Grid_ViewDonors = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ViewDonors)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(995, 593);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(987, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Donation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CheckBox_SendSMS_Donor);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.Date_DonationDate);
            this.groupBox4.Controls.Add(this.TextBox_DonationAmount);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Button_AddDonor);
            this.groupBox4.Controls.Add(this.Label_ErrorDonation);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.TextBox_DonorContact);
            this.groupBox4.Controls.Add(this.TextBox_DonorAddress);
            this.groupBox4.Controls.Add(this.TextBox_DonorGuardian);
            this.groupBox4.Controls.Add(this.TextBox_DonorName);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(34, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(914, 424);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Donor Details";
            // 
            // CheckBox_SendSMS_Donor
            // 
            this.CheckBox_SendSMS_Donor.AutoSize = true;
            this.CheckBox_SendSMS_Donor.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_SendSMS_Donor.Location = new System.Drawing.Point(573, 305);
            this.CheckBox_SendSMS_Donor.Name = "CheckBox_SendSMS_Donor";
            this.CheckBox_SendSMS_Donor.Size = new System.Drawing.Size(169, 20);
            this.CheckBox_SendSMS_Donor.TabIndex = 43;
            this.CheckBox_SendSMS_Donor.Text = "Appreciate Donor Via SMS";
            this.CheckBox_SendSMS_Donor.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(104, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Date of Donation";
            // 
            // Date_DonationDate
            // 
            this.Date_DonationDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DonationDate.Location = new System.Drawing.Point(247, 258);
            this.Date_DonationDate.MinDate = new System.DateTime(2017, 9, 14, 0, 0, 0, 0);
            this.Date_DonationDate.Name = "Date_DonationDate";
            this.Date_DonationDate.Size = new System.Drawing.Size(495, 24);
            this.Date_DonationDate.TabIndex = 40;
            // 
            // TextBox_DonationAmount
            // 
            this.TextBox_DonationAmount.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextBox_DonationAmount.Location = new System.Drawing.Point(597, 216);
            this.TextBox_DonationAmount.Name = "TextBox_DonationAmount";
            this.TextBox_DonationAmount.Size = new System.Drawing.Size(145, 24);
            this.TextBox_DonationAmount.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(451, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Donation Amount";
            // 
            // Button_AddDonor
            // 
            this.Button_AddDonor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.Button_AddDonor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_AddDonor.FlatAppearance.BorderSize = 0;
            this.Button_AddDonor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddDonor.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold);
            this.Button_AddDonor.ForeColor = System.Drawing.Color.White;
            this.Button_AddDonor.Location = new System.Drawing.Point(412, 370);
            this.Button_AddDonor.Name = "Button_AddDonor";
            this.Button_AddDonor.Size = new System.Drawing.Size(93, 27);
            this.Button_AddDonor.TabIndex = 9;
            this.Button_AddDonor.Text = "Save";
            this.Button_AddDonor.UseVisualStyleBackColor = false;
            this.Button_AddDonor.Click += new System.EventHandler(this.Button_AddDonor_Click);
            // 
            // Label_ErrorDonation
            // 
            this.Label_ErrorDonation.AutoSize = true;
            this.Label_ErrorDonation.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.Label_ErrorDonation.ForeColor = System.Drawing.Color.Red;
            this.Label_ErrorDonation.Location = new System.Drawing.Point(244, 339);
            this.Label_ErrorDonation.Name = "Label_ErrorDonation";
            this.Label_ErrorDonation.Size = new System.Drawing.Size(0, 15);
            this.Label_ErrorDonation.TabIndex = 37;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.Teal;
            this.label30.Location = new System.Drawing.Point(104, 56);
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
            this.label23.Location = new System.Drawing.Point(177, 90);
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
            this.label22.Location = new System.Drawing.Point(534, 220);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 21);
            this.label22.TabIndex = 32;
            this.label22.Text = "*";
            // 
            // TextBox_DonorContact
            // 
            this.TextBox_DonorContact.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextBox_DonorContact.Location = new System.Drawing.Point(247, 216);
            this.TextBox_DonorContact.Name = "TextBox_DonorContact";
            this.TextBox_DonorContact.Size = new System.Drawing.Size(190, 24);
            this.TextBox_DonorContact.TabIndex = 5;
            // 
            // TextBox_DonorAddress
            // 
            this.TextBox_DonorAddress.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextBox_DonorAddress.Location = new System.Drawing.Point(247, 174);
            this.TextBox_DonorAddress.Name = "TextBox_DonorAddress";
            this.TextBox_DonorAddress.Size = new System.Drawing.Size(495, 24);
            this.TextBox_DonorAddress.TabIndex = 4;
            // 
            // TextBox_DonorGuardian
            // 
            this.TextBox_DonorGuardian.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextBox_DonorGuardian.Location = new System.Drawing.Point(247, 130);
            this.TextBox_DonorGuardian.Name = "TextBox_DonorGuardian";
            this.TextBox_DonorGuardian.Size = new System.Drawing.Size(495, 24);
            this.TextBox_DonorGuardian.TabIndex = 2;
            // 
            // TextBox_DonorName
            // 
            this.TextBox_DonorName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextBox_DonorName.Location = new System.Drawing.Point(247, 86);
            this.TextBox_DonorName.Name = "TextBox_DonorName";
            this.TextBox_DonorName.Size = new System.Drawing.Size(495, 24);
            this.TextBox_DonorName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(104, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(104, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(104, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "S/o D/o W/o";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(104, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Full Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Button_PrintDonors);
            this.tabPage2.Controls.Add(this.Grid_ViewDonors);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(987, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Records";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Button_PrintDonors
            // 
            this.Button_PrintDonors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.Button_PrintDonors.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_PrintDonors.FlatAppearance.BorderSize = 0;
            this.Button_PrintDonors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_PrintDonors.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.Button_PrintDonors.ForeColor = System.Drawing.Color.White;
            this.Button_PrintDonors.Location = new System.Drawing.Point(412, 514);
            this.Button_PrintDonors.Name = "Button_PrintDonors";
            this.Button_PrintDonors.Size = new System.Drawing.Size(163, 27);
            this.Button_PrintDonors.TabIndex = 38;
            this.Button_PrintDonors.Text = "Export as PDF";
            this.Button_PrintDonors.UseVisualStyleBackColor = false;
            this.Button_PrintDonors.Click += new System.EventHandler(this.Button_PrintDonors_Click);
            // 
            // Grid_ViewDonors
            // 
            this.Grid_ViewDonors.AllowUserToAddRows = false;
            this.Grid_ViewDonors.AllowUserToDeleteRows = false;
            this.Grid_ViewDonors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_ViewDonors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_ViewDonors.BackgroundColor = System.Drawing.Color.White;
            this.Grid_ViewDonors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_ViewDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ViewDonors.GridColor = System.Drawing.Color.White;
            this.Grid_ViewDonors.Location = new System.Drawing.Point(15, 19);
            this.Grid_ViewDonors.Name = "Grid_ViewDonors";
            this.Grid_ViewDonors.ReadOnly = true;
            this.Grid_ViewDonors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_ViewDonors.Size = new System.Drawing.Size(958, 475);
            this.Grid_ViewDonors.TabIndex = 22;
            // 
            // FormDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 598);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDonors";
            this.Text = "FormDonors";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ViewDonors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Button_AddDonor;
        private System.Windows.Forms.Label Label_ErrorDonation;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TextBox_DonorContact;
        private System.Windows.Forms.TextBox TextBox_DonorAddress;
        private System.Windows.Forms.TextBox TextBox_DonorGuardian;
        private System.Windows.Forms.TextBox TextBox_DonorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_DonationAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Date_DonationDate;
        private System.Windows.Forms.CheckBox CheckBox_SendSMS_Donor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Grid_ViewDonors;
        private System.Windows.Forms.Button Button_PrintDonors;
    }
}