using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Citicon.DataManager;
using Citicon.Data;

namespace Citicon.Forms.Controls
{
    public partial class DeliveryConfirmationControl : UserControl
    {
        public DeliveryConfirmationControl()
        {
            InitializeComponent();
        }

        private async void DeliveryConfirmationControl_Load(object sender, EventArgs e)
        {
            await GetUnbilledDeliveryListAsync();
        }

        private async Task GetUnbilledDeliveryListAsync()
        {
            DeliveryDataGridView.Rows.Clear();

            try
            {
                var deliveries = await DeliveryManager.GetUnbilledDeliveryListAsync();

                if (deliveries != null && deliveries.Any())
                {
                    foreach (var delivery in deliveries)
                    {
                        AddToUI(delivery);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToUI(Delivery delivery)
        {
            if (delivery != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.PlantLeave });
                DeliveryDataGridView.Rows.Add(row);
            }
        }
    }
}
