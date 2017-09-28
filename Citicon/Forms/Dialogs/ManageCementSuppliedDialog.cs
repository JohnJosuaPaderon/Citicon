using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class ManageCementSuppliedDialog : Form
    {
        private const string FORMAT_DATETIME = "MMMM d, yyyy";
        private const string FORMAT_NUMERIC = "#,##0.00";

        public ManageCementSuppliedDialog(Delivery delivery)
        {
            Delivery = delivery ?? throw new ArgumentNullException(nameof(delivery));
            InitializeComponent();
        }

        private DeliveryConsumedCementSupplied _DeliveryConsumedCementSupplied;

        public Delivery Delivery { get; }
        public DeliveryConsumedCementSupplied DeliveryConsumedCementSupplied
        {
            get { return _DeliveryConsumedCementSupplied; }
            private set
            {
                _DeliveryConsumedCementSupplied = value;
                OnDeliveryConsumedCementSuppliedChanged();
            }
        }

        private void DisplayDelivery()
        {
            Delivery_DeliveryReceiptNumberTextBox.Text = Delivery.ToString();
            Delivery_ProjectDesignTextBox.Text = Delivery.ProjectDesign?.ToString();
            Delivery_DateTextBox.Text = Delivery.DeliveryDate.ToString(FORMAT_DATETIME);
            Delivery_VolumeTextBox.Text = Delivery.Volume.ToString(FORMAT_NUMERIC);
        }

        private async Task GetCementSuppliedListAsync()
        {
            CementSuppliedDataGridView.Rows.Clear();

            try
            {
                var suppliedCements = await StockManager.GetCementSuppliedListByProjectAsync(Delivery.Project);

                if (suppliedCements != null && suppliedCements.Any())
                {
                    foreach (var cementSupplied in suppliedCements)
                    {
                        DisplayToUi(cementSupplied);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task TryGetDeliveryConsumedCementSuppliedAsync()
        {
            try
            {
                if (CementSuppliedDataGridView.SelectedRows.Count == 1)
                {
                    var cementSupplied = CementSuppliedDataGridView.SelectedRows[0].Cells[CementSuppliedColumn.Name].Value as Stock;
                    CementSupplied_VolumeTextBox.Text = cementSupplied.AddedStockValue.ToString(FORMAT_NUMERIC);
                    CementSupplied_DeliveryDateTextBox.Text = cementSupplied.DeliveryDate.ToString(FORMAT_DATETIME);
                    var deliveryConsumedCementSupplied = await DeliveryConsumedCementSuppliedManager.GetAsync(cementSupplied, Delivery);

                    if (deliveryConsumedCementSupplied != null)
                    {
                        DeliveryConsumedCementSupplied = deliveryConsumedCementSupplied;
                    }
                    else
                    {
                        DeliveryConsumedCementSupplied = new DeliveryConsumedCementSupplied()
                        {
                            CementSupplied = cementSupplied,
                            Delivery = Delivery,
                            Amount = 0
                        };
                    }
                }
                else
                {
                    DeliveryConsumedCementSupplied = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayToUi(Stock cementSupplied)
        {
            var row = new DataGridViewRow
            {
                Height = 30
            };
            row.Cells.Add(new DataGridViewTextBoxCell { Value = cementSupplied });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = cementSupplied.AddedStockValue });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = cementSupplied.DeliveryDate });
            CementSuppliedDataGridView.Rows.Add(row);
        }

        private async Task SaveDeliveryConsumedCementSuppliedAsync()
        {
            if (DeliveryConsumedCementSupplied != null)
            {
                try
                {
                    DeliveryConsumedCementSupplied.Amount = CementSupplied_ConsumedNumericUpDown.Value;
                    var result = await DeliveryConsumedCementSuppliedManager.SaveAmountAsync(DeliveryConsumedCementSupplied);

                    if (result != null)
                    {
                        MessageBox.Show("Successfully saved.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void OnDeliveryConsumedCementSuppliedChanged()
        {
            CementSupplied_ConsumedNumericUpDown.Value = DeliveryConsumedCementSupplied?.Amount ?? 0M;
        }

        private async void ManageCementSuppliedDialog_Load(object sender, EventArgs e)
        {
            DisplayDelivery();
            await GetCementSuppliedListAsync();
        }

        private async void SaveCementSuppliedConsumedButton_Click(object sender, EventArgs e)
        {
            await SaveDeliveryConsumedCementSuppliedAsync();
        }

        private async void CementSuppliedDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await TryGetDeliveryConsumedCementSuppliedAsync();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
