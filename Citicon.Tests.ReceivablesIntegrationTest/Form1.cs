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

        private void BtnDeliveryScheduler_Click(object sender, EventArgs e)
        {
            var form = new DeliverySchedulerForm();
            form.Show();
        }

        private void BtnDeliveryForm_Click(object sender, EventArgs e)
        {
            var form = new DeliveryForm();
            form.Show();
        }

        private void BtnPurchaseOrderManagementForm_Click(object sender, EventArgs e)
        {
            var form = new PurchaseOrderManagementForm();
            form.ShowDialog();
        }
    }
}
