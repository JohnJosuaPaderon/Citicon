using Citicon.PayrollIntegration.Forms;
using System;
using System.Windows.Forms;

namespace Citicon.Tests.PayrollIntegrationTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSemiMonthlyPayrollForm_Click(object sender, EventArgs e)
        {
            var form = new SemiMonthlyPayrollForm();
            form.ShowDialog();
        }
    }
}
