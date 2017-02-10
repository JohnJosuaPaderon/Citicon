using Citicon.DataManager;
using System;
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
            ReportFilter.HasFiltered = hasFilteredChanged;
        }

        private ChequeSummaryItemManager ChequeSummaryItemManager;

        private void hasFilteredChanged(bool hasfiltered)
        {
            btnGenerate.Enabled = hasfiltered;
        }

        private async Task GetChequeSummaryIEnumerableAsync()
        {
            try
            {
                dgvCheques.Rows.Clear();
                var summaryItemIEnumerable = await ChequeSummaryItemManager.GetFilterIEnumerableAsync(ReportFilter.FilterByRangeDate, ReportFilter.RangeDate, ReportFilter.FilterBySupplier, ReportFilter.Supplier);

                if (summaryItemIEnumerable != null)
                {
                    foreach (var item in summaryItemIEnumerable)
                    {
                        var row = new DataGridViewRow();
                        row.Height = 30;

                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.ChequeNumbber });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.ChequeDate });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Supplier });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.BankAccount?.Bank });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.BankAccount });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.TotalAmount });

                        dgvCheques.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            await GetChequeSummaryIEnumerableAsync();
        }
    }
}
