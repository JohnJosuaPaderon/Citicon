using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Citicon.Data;
using Citicon.DataManager;
using System.Linq;

namespace Citicon.Forms.Controls
{
    public partial class DailyChequeReport : UserControl
    {
        public DailyChequeReport()
        {
            InitializeComponent();
            ChequeSummaryItemManager = new ChequeSummaryItemManager();
        }

        public IEnumerable<ChequeSummaryItem> ChequeSummaryList { get; private set; }
        private ChequeSummaryItemManager ChequeSummaryItemManager;

        private async Task LoadAsync()
        {
            ChequeDataGridView.Rows.Clear();

            try
            {
                ChequeSummaryList = await ChequeSummaryItemManager.GetFilterIEnumerableAsync(false, null, false, null, false, null, false, null, true, new DateTimeRange(TransactionDateTimePicker.Value, TransactionDateTimePicker.Value));

                if (ChequeSummaryList != null && ChequeSummaryList.Any())
                {
                    foreach (var chequeSummary in ChequeSummaryList)
                    {
                        AddToUI(chequeSummary);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToUI(ChequeSummaryItem chequeSummary)
        {
            if (chequeSummary != null)
            {
                var row = new DataGridViewRow
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = chequeSummary });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = chequeSummary.Supplier });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = chequeSummary.TotalAmount });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = chequeSummary.ChequeDate });
                ChequeDataGridView.Rows.Add(row);
            }
        }

        private async void LoadButton_Click(object sender, EventArgs e)
        {
            await LoadAsync();
        }
    }
}
