using Citicon.HumanResourceIntegration.Forms;
using System;
using System.Windows.Forms;

namespace Citicon.Tests.HumanResourceIntegrationTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmployeeManagementForm_Click(object sender, EventArgs e)
        {
            var form = new EmployeeManagementForm();
            form.ShowDialog();
        }
    }
}
