using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class InventoryReportForm : Form
    {
        public InventoryReportForm()
        {
            InitializeComponent();
            _Controller = new InventoryReportFormController(this);
        }

        private readonly InventoryReportFormController _Controller;

        private void IncomingStocksButton_Click(object sender, EventArgs e)
        {
            _Controller.OpenChild(InventoryReportFormContent.IncomingStocks);
        }

        private void OutgoingStocksButton_Click(object sender, EventArgs e)
        {
            _Controller.OpenChild(InventoryReportFormContent.OutgoingStocks);
        }
    }
}
