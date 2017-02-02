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
    public partial class ItemTrackingForm : Form
    {
        private Item currentItem;
        private ItemManager itemManager;
        private Tuple<Stock, Transaction>[] trackings;
        private const string DATE_TIME_FORMAT = "MMMM dd, yyyy hh:mm:ss tt";
        private const string NUMBER_FORMAT = "#,##0.00";
        public ItemTrackingForm(Item item)
        {
            InitializeComponent();
            currentItem = item;

            itemManager = new ItemManager();
            itemManager.ExceptionCatched += ExceptionCatched;
            itemManager.NewTrackRecordGenerated += ItemManager_NewTrackRecordGenerated;
        }

        private void ItemManager_NewTrackRecordGenerated(Tuple<Stock, Transaction> e)
        {
            Invoke(new Action(() =>
            {
                if (e.Item1 != null)
                {
                dgvItemTrackings.Rows.Add(e.Item1, e.Item1.DeliveryDate.ToString(DATE_TIME_FORMAT), e.Item1.Company, e.Item1.Branch, e.Item1.LastStockValue.ToString(NUMBER_FORMAT), e.Item1.AddedStockValue.ToString(NUMBER_FORMAT), "ADDED");
                }
                else if (e.Item2 != null)
                {
                    dgvItemTrackings.Rows.Add(e.Item2, e.Item2.TransactionDate.ToString(DATE_TIME_FORMAT), e.Item2.Company, e.Item2.Branch, e.Item2.LastStockValue.ToString(NUMBER_FORMAT), e.Item2.RemovedStockValue.ToString(NUMBER_FORMAT), "REMOVED");
                }
            }));
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private async void ItemTrackingForm_Load(object sender, EventArgs e)
        {
            tbxItemCode.Text = currentItem.Code;
            tbxItemDescription.Text = currentItem.Description;
            trackings = await itemManager.GetTrackingsAsync(currentItem);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxItemCode_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
