using Citicon.Data;
using Citicon.Inventory.Data;
using Citicon.Inventory.DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            Invoke(new Action(() =>
            {
                DataGridViewRow row = new DataGridViewRow();
                dgvItems.Rows.Add(e, e.SubClassification?.Classification, e.SubClassification, e.StockValue.ToString("#,##0.00"));
            }));
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            lblUserDisplayName.Text = User.CurrentUser.DisplayName;
            await getItems();
        }

        private async Task getItems()
        {
            dgvItems.Rows.Clear();
            items = await itemManager.GetListAsync();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            ItemManagerForm form = new ItemManagerForm();
            form.ShowDialog();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceForm form = new MaintenanceForm();
            form.Show();
        }

        private void btnIncomingStocks_Click(object sender, EventArgs e)
        {
            IncomingStocksform form = new IncomingStocksform();
            form.ShowDialog();
        }

        private void btnOutgoingStocks_Click(object sender, EventArgs e)
        {
            OutgoingStocksForm form = new OutgoingStocksForm();
            form.ShowDialog();
        }

        private void btnViewTracking_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 1)
            {
                ItemTrackingForm form = new ItemTrackingForm((Item)dgvItems.SelectedRows[0].Cells[colItems.Name].Value);
                form.ShowDialog();
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await getItems();
        }
    }
}
