using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Payables.Reports
{
    public partial class ChequeVoucherDetailsView : UserControl
    {
        public ChequeVoucherDetailsView()
        {
            InitializeComponent();
            PayableManager = new PayableManager();
        }

        private PayableManager PayableManager;

        private async Task SearchAsync()
        {
            var chequeVoucherNumber = tbxSearch.Text;

            if (string.IsNullOrWhiteSpace(chequeVoucherNumber))
            {
                MessageBox.Show("Nothing to search.");
            }
            else
            {
                dgvPayables.Rows.Clear();

                try
                {
                    var list = await PayableManager.GetChequeVoucherNumberDetailsAsync(chequeVoucherNumber);

                    if (list != null)
                    {
                        foreach (var item in list)
                        {
                            AddToDataGridView(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddToDataGridView(Payable payable)
        {
            var row = new DataGridViewRow()
            {
                Height = 30
            };
            row.Cells.Add(new DataGridViewTextBoxCell { Value = payable });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = payable.Description });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = payable.Branch });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = payable.Company });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = payable.Value });

            dgvPayables.Rows.Add(row);
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            await SearchAsync();
        }
    }
}
