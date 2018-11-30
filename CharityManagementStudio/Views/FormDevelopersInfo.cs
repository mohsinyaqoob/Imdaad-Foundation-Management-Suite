using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharityManagementStudio.Views
{
    public partial class FormDevelopersInfo : Form
    {
        public FormDevelopersInfo()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            FormDevelopersInfo developers = null;
            this.Close();
        }
    }
}
