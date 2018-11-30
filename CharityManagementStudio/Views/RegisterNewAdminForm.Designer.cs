namespace CharityManagementStudio.Views
{
    partial class RegisterNewAdminForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonRegisterAdmin = new System.Windows.Forms.Button();
            this.TextConfirmPassword = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.TextAdministratorID = new System.Windows.Forms.TextBox();
            this.TextOrganizationName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonRegisterAdmin);
            this.groupBox1.Controls.Add(this.TextConfirmPassword);
            this.groupBox1.Controls.Add(this.TextPassword);
            this.groupBox1.Controls.Add(this.TextAdministratorID);
            this.groupBox1.Controls.Add(this.TextOrganizationName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            // 
            // ButtonRegisterAdmin
            // 
            this.ButtonRegisterAdmin.Location = new System.Drawing.Point(289, 174);
            this.ButtonRegisterAdmin.Name = "ButtonRegisterAdmin";
            this.ButtonRegisterAdmin.Size = new System.Drawing.Size(113, 32);
            this.ButtonRegisterAdmin.TabIndex = 5;
            this.ButtonRegisterAdmin.Text = "Register";
            this.ButtonRegisterAdmin.UseVisualStyleBackColor = true;
            this.ButtonRegisterAdmin.Click += new System.EventHandler(this.ButtonRegisterAdmin_Click);
            // 
            // TextConfirmPassword
            // 
            this.TextConfirmPassword.Location = new System.Drawing.Point(178, 129);
            this.TextConfirmPassword.Name = "TextConfirmPassword";
            this.TextConfirmPassword.PasswordChar = '*';
            this.TextConfirmPassword.Size = new System.Drawing.Size(224, 26);
            this.TextConfirmPassword.TabIndex = 4;
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(178, 97);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(224, 26);
            this.TextPassword.TabIndex = 3;
            // 
            // TextAdministratorID
            // 
            this.TextAdministratorID.Location = new System.Drawing.Point(178, 65);
            this.TextAdministratorID.Name = "TextAdministratorID";
            this.TextAdministratorID.Size = new System.Drawing.Size(224, 26);
            this.TextAdministratorID.TabIndex = 2;
            // 
            // TextOrganizationName
            // 
            this.TextOrganizationName.Location = new System.Drawing.Point(178, 34);
            this.TextOrganizationName.Name = "TextOrganizationName";
            this.TextOrganizationName.Size = new System.Drawing.Size(224, 26);
            this.TextOrganizationName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administrator ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Organization Name";
            // 
            // RegisterNewAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 257);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RegisterNewAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imdaad Foundation - Register New Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextConfirmPassword;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.TextBox TextAdministratorID;
        private System.Windows.Forms.TextBox TextOrganizationName;
        private System.Windows.Forms.Button ButtonRegisterAdmin;
    }
}