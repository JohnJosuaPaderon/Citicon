using Citicon.ReceivablesIntegration.Forms;
using System;
using System.Windows.Forms;

namespace Citicon.Tests.ReceivablesIntegrationTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeliveryScheduler_Click(object sender, EventArgs e)
        {
            var form = new DeliverySchedulerForm();
            form.Show();
        }

        private void btnDeliveryForm_Click(object sender, EventArgs e)
        {
            var form = new DeliveryForm();
            form.Show();
        }
    }
}
