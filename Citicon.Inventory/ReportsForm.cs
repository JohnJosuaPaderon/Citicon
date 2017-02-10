using System;
using System.Windows.Forms;

namespace Citicon.Inventory
{
    public enum ReportType
    {
        Daily,
        Weekly,
        Monthly
    }
    public partial class ReportsForm : Form
    {
        ReportType incomingStocksReportType;
        public ReportsForm()
        {
            InitializeComponent();
            cmbxIncomingStocksReportType.Items.AddRange(Enum.GetNames(typeof(ReportType)));
            dtpIncomingStocksDailyDate.Tag = ReportType.Daily;
            dtpIncomingStocksWeeklyRangeEnd.Tag = ReportType.Weekly;
            dtpIncomingStocksWeeklyRangeStart.Tag = ReportType.Weekly;
            lblIncomingStocksWeeklyTo.Tag = ReportType.Weekly;
            cmbxIncomingStocksMonthlyMonth.Tag = ReportType.Monthly;
        }

        private void showIncomingReportSettings()
        {
            foreach (Control control in panelIncomingStocksSettings.Controls)
            {
                control.Visible = control.Tag is ReportType ? (ReportType)Enum.Parse(typeof(ReportType), control.Tag.ToString()) == (ReportType)Enum.Parse(typeof(ReportType), cmbxIncomingStocksReportType.SelectedItem.ToString()) : true;
            }
        }

        private void cmbxIncomingStocksReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            incomingStocksReportType = (ReportType)Enum.Parse(typeof(ReportType), cmbxIncomingStocksReportType.SelectedItem.ToString());
            switch (incomingStocksReportType)
            {
                case ReportType.Daily:
                    lblIncomingStocksSelect.Text = "Select Date";
                    break;
                case ReportType.Weekly:
                    lblIncomingStocksSelect.Text = "Select Range";
                    break;
                case ReportType.Monthly:
                    lblIncomingStocksSelect.Text = "Select Month";
                    break;
                default:
                    lblIncomingStocksSelect.Text = "Select";
                    break;
            }
            showIncomingReportSettings();
        }
    }
}
