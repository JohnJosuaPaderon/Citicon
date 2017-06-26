using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class PurchaseOrderMonitoringForm : Form
    {
        public PurchaseOrderMonitoringForm()
        {
            InitializeComponent();
        }

        private async Task GetPurchaseOrderListAsync()
        {
            PurchaseOrderDataGridView.Rows.Clear();

            try
            {
                var list = await PurchaseOrderManager.GetListBySelectorAsync(PurchaseOrderSelector.All);

                if (list != null && list.Any())
                {
                    foreach (var item in list)
                    {
                        AddToUI(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToUI(PurchaseOrder item)
        {
            if (item != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.MaximumCumulativePricePerCubicMeter });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Project });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Project?.Client });
                PurchaseOrderDataGridView.Rows.Add(row);
            }
        }

        private async void PurchaseOrderMonitoringForm_Load(object sender, EventArgs e)
        {
            await GetPurchaseOrderListAsync();
        }
    }
}
