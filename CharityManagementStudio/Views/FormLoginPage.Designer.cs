namespace CharityManagementStudio
{
    partial class FormAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminLogin));
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonMinimizeWindow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextAdminId = new System.Windows.Forms.TextBox();
            this.TextAdminPassword = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.LabelErrorMessage = new System.Windows.Forms.Label();
            this.ButtonNewAdmin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(377, 6);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(27, 25);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.Text = "X";
            this.ButtonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonMinimizeWindow
            // 
            this.ButtonMinimizeWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.ButtonMinimizeWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.ButtonMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimizeWindow.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ButtonMinimizeWindow.ForeColor = System.Drawing.Color.White;
            this.ButtonMinimizeWindow.Location = new System.Drawing.Point(344, 6);
            this.ButtonMinimizeWindow.Name = "ButtonMinimizeWindow";
            this.ButtonMinimizeWindow.Size = new System.Drawing.Size(27, 25);
            this.ButtonMinimizeWindow.TabIndex = 1;
            this.ButtonMinimizeWindow.Text = "-";
            this.ButtonMinimizeWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonMinimizeWindow.UseVisualStyleBackColor = false;
            this.ButtonMinimizeWindow.Click += new System.EventHandler(this.ButtonMinimizeWindow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.Location = new System.Drawing.Point(43, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imdaad Foundation SUITE 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // TextAdminId
            // 
            this.TextAdminId.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextAdminId.Location = new System.Drawing.Point(129, 59);
            this.TextAdminId.Name = "TextAdminId";
            this.TextAdminId.Size = new System.Drawing.Size(224, 24);
            this.TextAdminId.TabIndex = 1;
            this.TextAdminId.Text = "imdaadfoundation";
            // 
            // TextAdminPassword
            // 
            this.TextAdminPassword.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextAdminPassword.Location = new System.Drawing.Point(129, 95);
            this.TextAdminPassword.Name = "TextAdminPassword";
            this.TextAdminPassword.PasswordChar = '*';
            this.TextAdminPassword.Size = new System.Drawing.Size(224, 24);
            this.TextAdminPassword.TabIndex = 2;
            this.TextAdminPassword.Text = "admin";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(177)))), ((int)(((byte)(214)))));
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(277, 144);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(75, 32);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // LabelErrorMessage
            // 
            this.LabelErrorMessage.AutoSize = true;
            this.LabelErrorMessage.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.LabelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.LabelErrorMessage.Location = new System.Drawing.Point(133, 20);
            this.LabelErrorMessage.Name = "LabelErrorMessage";
            this.LabelErrorMessage.Size = new System.Drawing.Size(0, 16);
            this.LabelErrorMessage.TabIndex = 2;
            this.LabelErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonNewAdmin
            // 
            this.ButtonNewAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.ButtonNewAdmin.FlatAppearance.BorderSize = 0;
            this.ButtonNewAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNewAdmin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ButtonNewAdmin.ForeColor = System.Drawing.Color.White;
            this.ButtonNewAdmin.Location = new System.Drawing.Point(129, 144);
            this.ButtonNewAdmin.Name = "ButtonNewAdmin";
            this.ButtonNewAdmin.Size = new System.Drawing.Size(142, 32);
            this.ButtonNewAdmin.TabIndex = 4;
            this.ButtonNewAdmin.Text = "New Admin?";
            this.ButtonNewAdmin.UseVisualStyleBackColor = false;
            this.ButtonNewAdmin.Click += new System.EventHandler(this.ButtonNewAdmin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonNewAdmin);
            this.groupBox1.Controls.Add(this.LabelErrorMessage);
            this.groupBox1.Controls.Add(this.ButtonLogin);
            this.groupBox1.Controls.Add(this.TextAdminPassword);
            this.groupBox1.Controls.Add(this.TextAdminId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(10, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // FormAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 287);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonMinimizeWindow);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imdaad Foundation - Management Studio";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAdminLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAdminLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAdminLogin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonMinimizeWindow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextAdminId;
        private System.Windows.Forms.TextBox TextAdminPassword;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label LabelErrorMessage;
        private System.Windows.Forms.Button ButtonNewAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

