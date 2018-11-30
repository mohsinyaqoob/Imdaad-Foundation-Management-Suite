namespace CharityManagementStudio.Views
{
    partial class FormRegisterAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.LabelErrorMessage = new System.Windows.Forms.Label();
            this.TextConfirmPassword = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.TextAdministratorID = new System.Windows.Forms.TextBox();
            this.TextOrganizationName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonMinimizeWindow = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonRegister);
            this.groupBox1.Controls.Add(this.LabelErrorMessage);
            this.groupBox1.Controls.Add(this.TextConfirmPassword);
            this.groupBox1.Controls.Add(this.TextPassword);
            this.groupBox1.Controls.Add(this.TextAdministratorID);
            this.groupBox1.Controls.Add(this.TextOrganizationName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.ButtonRegister.FlatAppearance.BorderSize = 0;
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ButtonRegister.ForeColor = System.Drawing.Color.White;
            this.ButtonRegister.Location = new System.Drawing.Point(298, 194);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(98, 32);
            this.ButtonRegister.TabIndex = 7;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // LabelErrorMessage
            // 
            this.LabelErrorMessage.AutoSize = true;
            this.LabelErrorMessage.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.LabelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.LabelErrorMessage.Location = new System.Drawing.Point(134, 26);
            this.LabelErrorMessage.Name = "LabelErrorMessage";
            this.LabelErrorMessage.Size = new System.Drawing.Size(0, 16);
            this.LabelErrorMessage.TabIndex = 6;
            this.LabelErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextConfirmPassword
            // 
            this.TextConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextConfirmPassword.Location = new System.Drawing.Point(176, 153);
            this.TextConfirmPassword.Name = "TextConfirmPassword";
            this.TextConfirmPassword.PasswordChar = '*';
            this.TextConfirmPassword.Size = new System.Drawing.Size(220, 24);
            this.TextConfirmPassword.TabIndex = 4;
            // 
            // TextPassword
            // 
            this.TextPassword.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextPassword.Location = new System.Drawing.Point(176, 121);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(220, 24);
            this.TextPassword.TabIndex = 3;
            // 
            // TextAdministratorID
            // 
            this.TextAdministratorID.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextAdministratorID.Location = new System.Drawing.Point(176, 89);
            this.TextAdministratorID.Name = "TextAdministratorID";
            this.TextAdministratorID.Size = new System.Drawing.Size(220, 24);
            this.TextAdministratorID.TabIndex = 2;
            // 
            // TextOrganizationName
            // 
            this.TextOrganizationName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextOrganizationName.Location = new System.Drawing.Point(176, 58);
            this.TextOrganizationName.Name = "TextOrganizationName";
            this.TextOrganizationName.Size = new System.Drawing.Size(220, 24);
            this.TextOrganizationName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administrator ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Organization Name";
            // 
            // ButtonMinimizeWindow
            // 
            this.ButtonMinimizeWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.ButtonMinimizeWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.ButtonMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimizeWindow.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ButtonMinimizeWindow.ForeColor = System.Drawing.Color.White;
            this.ButtonMinimizeWindow.Location = new System.Drawing.Point(371, 8);
            this.ButtonMinimizeWindow.Name = "ButtonMinimizeWindow";
            this.ButtonMinimizeWindow.Size = new System.Drawing.Size(27, 25);
            this.ButtonMinimizeWindow.TabIndex = 2;
            this.ButtonMinimizeWindow.Text = "-";
            this.ButtonMinimizeWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonMinimizeWindow.UseVisualStyleBackColor = false;
            this.ButtonMinimizeWindow.Click += new System.EventHandler(this.ButtonMinimizeWindow_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(404, 8);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(27, 25);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "X";
            this.ButtonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label5.Location = new System.Drawing.Point(53, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Imdaad Foundation Suite 1.1";
            // 
            // FormRegisterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 319);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonMinimizeWindow);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegisterAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imdaad Foundation - Register New Admin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRegisterAdmin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormRegisterAdmin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormRegisterAdmin_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button ButtonMinimizeWindow;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelErrorMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonRegister;
    }
}