using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class OutgoingStockReportForm : Form
    {
        public OutgoingStockReportForm()
        {
            InitializeComponent();
            _Controller = new OutgoingStockReportFormController(this);
        }

        private readonly OutgoingStockReportFormController _Controller;

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            await _Controller.GetFilteredOutgoingStocksAsync();
        }

        private async void OutgoingStockReportForm_Load(object sender, EventArgs e)
        {
            await _Controller.InitializeAsync();
        }

        private async void ExportButton_Click(object sender, EventArgs e)
        {
            await _Controller.ExportAsync();
        }
    }
}
