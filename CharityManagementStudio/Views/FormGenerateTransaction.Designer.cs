namespace CharityManagementStudio.Views
{
    partial class FormGenerateTransaction
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
            this.Button_PrintGenerateTransaction = new System.Windows.Forms.Button();
            this.Grid_GenerateTransaction = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_GenerateTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(997, 596);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Button_PrintGenerateTransaction);
            this.tabPage1.Controls.Add(this.Grid_GenerateTransaction);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(989, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transaction List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Button_PrintGenerateTransaction
            // 
            this.Button_PrintGenerateTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.Button_PrintGenerateTransaction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_PrintGenerateTransaction.FlatAppearance.BorderSize = 0;
            this.Button_PrintGenerateTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_PrintGenerateTransaction.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.Button_PrintGenerateTransaction.ForeColor = System.Drawing.Color.White;
            this.Button_PrintGenerateTransaction.Location = new System.Drawing.Point(417, 517);
            this.Button_PrintGenerateTransaction.Name = "Button_PrintGenerateTransaction";
            this.Button_PrintGenerateTransaction.Size = new System.Drawing.Size(163, 27);
            this.Button_PrintGenerateTransaction.TabIndex = 38;
            this.Button_PrintGenerateTransaction.Text = "Export as PDF";
            this.Button_PrintGenerateTransaction.UseVisualStyleBackColor = false;
            this.Button_PrintGenerateTransaction.Click += new System.EventHandler(this.Button_PrintGenerateTransaction_Click);
            // 
            // Grid_GenerateTransaction
            // 
            this.Grid_GenerateTransaction.AllowUserToAddRows = false;
            this.Grid_GenerateTransaction.AllowUserToDeleteRows = false;
            this.Grid_GenerateTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_GenerateTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_GenerateTransaction.BackgroundColor = System.Drawing.Color.White;
            this.Grid_GenerateTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_GenerateTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_GenerateTransaction.GridColor = System.Drawing.Color.White;
            this.Grid_GenerateTransaction.Location = new System.Drawing.Point(12, 40);
            this.Grid_GenerateTransaction.Name = "Grid_GenerateTransaction";
            this.Grid_GenerateTransaction.ReadOnly = true;
            this.Grid_GenerateTransaction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_GenerateTransaction.Size = new System.Drawing.Size(961, 456);
            this.Grid_GenerateTransaction.TabIndex = 21;
            // 
            // FormGenerateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 598);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGenerateTransaction";
            this.Text = "FormGenerateTransaction";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_GenerateTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Grid_GenerateTransaction;
        private System.Windows.Forms.Button Button_PrintGenerateTransaction;
    }
}