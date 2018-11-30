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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonNewAdmin = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.TextAdminPassword = new System.Windows.Forms.TextBox();
            this.TextAdminId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonNewAdmin);
            this.groupBox1.Controls.Add(this.ButtonLogin);
            this.groupBox1.Controls.Add(this.TextAdminPassword);
            this.groupBox1.Controls.Add(this.TextAdminId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // ButtonNewAdmin
            // 
            this.ButtonNewAdmin.Location = new System.Drawing.Point(121, 121);
            this.ButtonNewAdmin.Name = "ButtonNewAdmin";
            this.ButtonNewAdmin.Size = new System.Drawing.Size(142, 32);
            this.ButtonNewAdmin.TabIndex = 4;
            this.ButtonNewAdmin.Text = "New Admin?";
            this.ButtonNewAdmin.UseVisualStyleBackColor = true;
            this.ButtonNewAdmin.Click += new System.EventHandler(this.ButtonNewAdmin_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(269, 121);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(75, 32);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // TextAdminPassword
            // 
            this.TextAdminPassword.Location = new System.Drawing.Point(121, 72);
            this.TextAdminPassword.Name = "TextAdminPassword";
            this.TextAdminPassword.PasswordChar = '*';
            this.TextAdminPassword.Size = new System.Drawing.Size(224, 26);
            this.TextAdminPassword.TabIndex = 2;
            // 
            // TextAdminId
            // 
            this.TextAdminId.Location = new System.Drawing.Point(121, 36);
            this.TextAdminId.Name = "TextAdminId";
            this.TextAdminId.Size = new System.Drawing.Size(224, 26);
            this.TextAdminId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin ID";
            // 
            // FormAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 209);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imdaad Foundation - Management Studio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox TextAdminPassword;
        private System.Windows.Forms.TextBox TextAdminId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonNewAdmin;
    }
}

