using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Payables.Reports
{
    public partial class ChequeReports : UserControl
    {
        public ChequeReports()
        {
            InitializeComponent();
            ChequeSummaryItemManager = new ChequeSummaryItemManager();
            PayableManager = new PayableManager();
        }

        private ChequeSummaryItemManager ChequeSummaryItemManager;
        private IEnumerable<ChequeSummaryItem> ChequeSummaryItems { get; set; }
        private PayableManager PayableManager;

        private void HasFilteredChanged(bool hasfiltered)
        {
            btnGenerate.Enabled = hasfiltered;
        }

        public async Task ExportAsync()
        {
            await PayableManager.ExportChequeReportAsync(ChequeSummaryItems);
        }

        private async Task GetChequeSummaryIEnumerableAsync()
        {
            try
            {
                dgvCheques.Rows.Clear();
                ChequeSummaryItems = await ChequeSummaryItemManager.GetFilterIEnumerableAsync(
                    ReportFilter.FilterByRangeDate, ReportFilter.RangeDate,
                    ReportFilter.FilterBySupplier, ReportFilter.Supplier,
                    ReportFilter.FilterByBranch, ReportFilter.Branch,
                    ReportFilter.FilterByCompany, ReportFilter.Company,
                    ReportFilter.FilterByTransactionDate, ReportFilter.TransactionDate);

                if (ChequeSummaryItems != null)
                {
                    decimal totalDisbursement = 0;

                    foreach (var item in ChequeSummaryItems)
                    {
                        var row = new DataGridViewRow()
                        {
                            Height = 30
                        };
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.ChequeNumbber });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.ChequeDate });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.TransactionDate });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Supplier });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.BankAccount?.Bank });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.BankAccount });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.TotalAmount });

                        dgvCheques.Rows.Add(row);

                        totalDisbursement += item.TotalAmount;
                    }

                    tbxTotalDisbursement.Text = totalDisbursement.ToString("#,##0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnGenerate_Click(object sender, EventArgs e)
        {
            await GetChequeSummaryIEnumerableAsync();
        }

        private void ChequeReports_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ReportFilter.HasFiltered = HasFilteredChanged; 
            }
        }
    }
}
