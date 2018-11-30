namespace CharityManagementStudio.Views
{
    partial class FormViewAllCases
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Button_ExportAllCasesToPDF = new System.Windows.Forms.Button();
            this.ComboBox_ViewCasesSort = new System.Windows.Forms.ComboBox();
            this.Remarks_DataGrid = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Remarks_DataGrid)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(995, 594);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.Button_ExportAllCasesToPDF);
            this.tabPage1.Controls.Add(this.ComboBox_ViewCasesSort);
            this.tabPage1.Controls.Add(this.Remarks_DataGrid);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(987, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Cases";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(839, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 17);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "All Cases not Visible?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Button_ExportAllCasesToPDF
            // 
            this.Button_ExportAllCasesToPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.Button_ExportAllCasesToPDF.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_ExportAllCasesToPDF.FlatAppearance.BorderSize = 0;
            this.Button_ExportAllCasesToPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ExportAllCasesToPDF.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.Button_ExportAllCasesToPDF.ForeColor = System.Drawing.Color.White;
            this.Button_ExportAllCasesToPDF.Location = new System.Drawing.Point(424, 19);
            this.Button_ExportAllCasesToPDF.Name = "Button_ExportAllCasesToPDF";
            this.Button_ExportAllCasesToPDF.Size = new System.Drawing.Size(163, 27);
            this.Button_ExportAllCasesToPDF.TabIndex = 37;
            this.Button_ExportAllCasesToPDF.Text = "Export as PDF";
            this.Button_ExportAllCasesToPDF.UseVisualStyleBackColor = false;
            this.Button_ExportAllCasesToPDF.Click += new System.EventHandler(this.Button_ExportAllCasesToPDF_Click);
            // 
            // ComboBox_ViewCasesSort
            // 
            this.ComboBox_ViewCasesSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ComboBox_ViewCasesSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_ViewCasesSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_ViewCasesSort.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ComboBox_ViewCasesSort.Items.AddRange(new object[] {
            "All Cases",
            "Monthly Assistance Cases",
            "Medical Assistance Cases",
            "Marriage Fund Assistance Cases",
            "Employment Assistance Cases",
            "One-Time Rehabilated Cases",
            "Other Cases",
            "All Rejected Cases",
            "All Accepted Cases",
            "All Pending Cases",
            "ALL (INCLUDING INCOMPLETE CASES)"});
            this.ComboBox_ViewCasesSort.Location = new System.Drawing.Point(13, 21);
            this.ComboBox_ViewCasesSort.Name = "ComboBox_ViewCasesSort";
            this.ComboBox_ViewCasesSort.Size = new System.Drawing.Size(401, 25);
            this.ComboBox_ViewCasesSort.TabIndex = 36;
            this.ComboBox_ViewCasesSort.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_ReasonForApproaching_SelectionChangeCommitted);
            // 
            // Remarks_DataGrid
            // 
            this.Remarks_DataGrid.AllowUserToAddRows = false;
            this.Remarks_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Remarks_DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Remarks_DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.Remarks_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Remarks_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Remarks_DataGrid.GridColor = System.Drawing.Color.White;
            this.Remarks_DataGrid.Location = new System.Drawing.Point(13, 88);
            this.Remarks_DataGrid.Name = "Remarks_DataGrid";
            this.Remarks_DataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Remarks_DataGrid.Size = new System.Drawing.Size(955, 439);
            this.Remarks_DataGrid.TabIndex = 20;
            // 
            // FormViewAllCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 598);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewAllCases";
            this.Text = "FormViewAllCases";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Remarks_DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Remarks_DataGrid;
        private System.Windows.Forms.ComboBox ComboBox_ViewCasesSort;
        private System.Windows.Forms.Button Button_ExportAllCasesToPDF;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}