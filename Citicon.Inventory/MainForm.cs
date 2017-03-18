using Citicon.Data;
using Citicon.Inventory.Data;
using Citicon.Inventory.DataManager;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Inventory
{
    public partial class MainForm : Form
    {
        ItemManager itemManager;
        Item[] items;
        public MainForm()
        {
            InitializeComponent();
            itemManager = new ItemManager();
            itemManager.ExceptionCatched += ExceptionCatched;
            itemManager.NewItemGenerated += ItemManager_NewItemGenerated;
        }

        private void ItemManager_NewItemGenerated(Item e)
        {
            Parallel.Invoke(() =>
            {
                Invoke(new Action(() =>
                {
                    DataGridViewRow row = new DataGridViewRow();
                    dgvItems.Rows.Add(e, e.Classification, e.Code, e.MeasurementUnit, e.StockValue.ToString("#,##0.00"));
                }));
            });
        }

        private bool ExistsInDataGridView(Item item)
        {
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                var x = (Item)row.Cells[colItems.Name].Value;
                if (item.Equals(x)) return true;
            }
            return false;
        }

        private void DisplayItems()
        {
            foreach (Item item in items)
            {
                Parallel.Invoke(() =>
                {
                    Invoker(() =>
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        var _item = new DataGridViewTextBoxCell { Value = item };
                        var _classification = new DataGridViewTextBoxCell { Value = item.Classification };
                        var _code = new DataGridViewTextBoxCell { Value = item.Code };
                        var _measurementUnit = new DataGridViewTextBoxCell { Value = item.MeasurementUnit };
                        var _stockValue = new DataGridViewTextBoxCell { Value = item.StockValue.ToString("#,##0.00") };
                        row.Cells.Add(_item);
                        row.Cells.Add(_classification);
                        row.Cells.Add(_code);
                        row.Cells.Add(_measurementUnit);
                        row.Cells.Add(_stockValue);
                        DataGridViewRow x_Row = null;
                        foreach (DataGridViewRow x in dgvItems.Rows)
                        {
                            if (item.Equals(x.Cells[colItems.Name].Value))
                            {
                                x_Row = x;
                                break;
                            }
                        }
                        //dgvItems.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => item.Equals((Item)x.Cells[colItems.Name].Value));
                        if (ExistsInDataGridView(item))
                        {
                            x_Row.Cells[colItems.Name].Value = _item.Value;
                            x_Row.Cells[colItemsClassification.Name].Value = _classification.Value;
                            x_Row.Cells[colItemsCode.Name].Value = _code.Value;
                            x_Row.Cells[colItemsMeasurementUnit.Name].Value = _measurementUnit.Value;
                            x_Row.Cells[colItemsStockValue.Name].Value = _stockValue.Value;
                        }
                        else
                        {
                            Invoker(() => dgvItems.Rows.Insert(x_Row != null ? x_Row.Index : dgvItems.Rows.Count, row));
                        }
                    });
                });
            }
        }
        
        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (User.CurrentUser.Inventory_OutgoingStocksOnly)
            {
                btnRefresh.Enabled = false;
                btnItems.Enabled = false;
                btnIncomingStocks.Enabled = false;
                btnReports.Enabled = false;
                btnViewTracking.Enabled = false;
                BtnOutgoingStocks_Click(this, EventArgs.Empty);
            }
            else
            {
                lblUserDisplayName.Text = User.CurrentUser?.DisplayName;
                GetItems();
            }
        }

        private void Invoker(Action method)
        {
            try { Invoke(method); }
            catch (Exception ex) { ExceptionCatched(ex); }
        }

        private void GetItems()
        {
            lblMessage.Visible = true;
            var task = itemManager.GetListAsync();
            task.ContinueWith(x =>
            {
                items = task.Result;
                DisplayItems();
                Invoker(() => lblMessage.Visible = false);
                itemManager.NewItemGenerated -= ItemManager_NewItemGenerated;
            });
        }

        private void BtnItems_Click(object sender, EventArgs e)
        {
            ItemManagerForm form = new ItemManagerForm();
            form.ShowDialog();
        }

        private void BtnMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceForm form = new MaintenanceForm();
            form.Show();
            lblUserDisplayName.Text = User.CurrentUser?.DisplayName;
        }

        private void BtnIncomingStocks_Click(object sender, EventArgs e)
        {
            IncomingStocksform form = new IncomingStocksform();
            form.ShowDialog();
        }

        private void BtnOutgoingStocks_Click(object sender, EventArgs e)
        {
            OutgoingStocksForm form = new OutgoingStocksForm();
            form.ShowDialog();
        }

        private void BtnViewTracking_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 1)
            {
                ItemTrackingForm form = new ItemTrackingForm((Item)dgvItems.SelectedRows[0].Cells[colItems.Name].Value);
                form.ShowDialog();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            GetItems();
        }

        private void LblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User.CurrentUser = null;
            Close();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            ReportsForm form = new ReportsForm();
            form.ShowDialog();
        }

        private void TbxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                var item = (Item)row.Cells[colItems.Name].Value;
                if (item.Description.ToUpper().Contains(tbxSearch.Text.Trim().ToUpper()))
                {
                    dgvItems.FirstDisplayedScrollingRowIndex = row.Index;
                    row.Selected = true;
                    return;
                }
            }
        }
    }
}