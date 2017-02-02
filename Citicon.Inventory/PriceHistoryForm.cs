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
    public partial class PriceHistoryForm : Form
    {
        List<Tuple<DateTime, decimal>> priceHistory;

        ItemManager itemManager;
        public PriceHistoryForm(Item item)
        {
            InitializeComponent();
            itemManager = new ItemManager();
            priceHistory = itemManager.GetPriceHistory(item);
            
        }

        private void PriceHistoryForm_Load(object sender, EventArgs e)
        {
            if (priceHistory != null)
            {
                foreach (var item in priceHistory)
                {
                    dgvPriceHistory.Rows.Add(item.Item1.ToString("MMMM dd, yyyy"), item.Item2.ToString("#,##0.00"));
                }
            }
        }
    }
}
