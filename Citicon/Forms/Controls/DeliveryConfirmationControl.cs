using System;
using System.Linq;
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

        private Delivery _CurrentDelivery;

        public Delivery CurrentDelivery
        {
            get { return _CurrentDelivery; }
            set
            {
                if (_CurrentDelivery != value)
                {
                    _CurrentDelivery = value;
                    DisplayCurrent(value);
                }
            }
        }

        private void DisplayCurrent(Delivery value)
        {
            Design_MixTypeTextBox.Text = value?.ProjectDesign?.MixType.ToString();
            Design_PsiTextBox.Text = value?.ProjectDesign?.Psi.ToString("#,##0.00");
            Design_InitialVolumeTextBox.Text = value?.ProjectDesign?.InitialVolume.ToString("#,##0.00");
            Design_AggregateTextBox.Text = value?.ProjectDesign?.Aggregate?.ToString();
            Design_StrengthTextBox.Text = value?.ProjectDesign?.Strength?.ToString();
            DeliveryDateTextBox.Text = value?.DeliveryDate.ToString("MMM d, yyyy");
            DeliveredVolumeTextBox.Text = value?.Volume.ToString("#,##0.00");
            RouteTextBox.Text = value?.Route?.ToString();
            PlantTextBox.Text = value?.Branch?.ToString();
            DriverTextBox.Text = value?.Driver?.ToString();
            TransitMixerTextBox.Text = value?.TransitMixer?.ToString();
            AdmixtureTextBox.Text = value?.Admixture;
            AdmixtureQuantityTextBox.Text = value?.AdmixtureQuantity;
            PlantLeaveTextBox.Text = value?.PlantLeave?.ToString("MMM d, yyyy");
            LoadTextBox.Text = value?.Load;
            MaxSlumpTextBox.Text = value?.MaxSlump.ToString("#,##0.00");
            ProjectArriveCheckBox.Checked = false;
            PlantArriveCheckBox.Checked = false;
            StartUnloadingCheckBox.Checked = false;
            FinishedUnloadingCheckBox.Checked = false;
            EstimatedStayCheckBox.Checked = false;
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
                var deliveries = await DeliveryManager.GetUnbilledDeliveryListAsync(FilterByDeliveryDateCheckBox.Checked, FilterByDeliveryDateTimePicker.Value);

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
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.DeliveryReceiptNumberDisplay });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.Project?.Client });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.Project });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.PlantLeave });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.ScheduleStatus });
                DeliveryDataGridView.Rows.Add(row);
            }
        }

        private void DeliveryDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DeliveryDataGridView.SelectedRows.Count == 1 && DeliveryDataGridView.SelectedRows[0].Cells[DeliveryColumn.Name].Value is Delivery delivery)
            {
                CurrentDelivery = delivery;
            }
        }

        private async void ConfirmDeliveryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentDelivery != null)
                {
                    var delivery = await DeliveryManager.ConfirmDeliveryAsync(CurrentDelivery);

                    if (delivery != null)
                    {
                        await GetUnbilledDeliveryListAsync();
                        MessageBox.Show("Delivery has been confirmed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to confirm delivery.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetCurrentDeliveryProperty(Action method)
        {
            if (CurrentDelivery != null)
            {
                method?.Invoke();
            }
        }

        private void SetCurrentDeliveryProjectArrive()
        {
            SetCurrentDeliveryProperty(() =>
            {
                CurrentDelivery.ProjectArrive = ProjectArriveCheckBox.Checked ? new DateTime?(ProjectArriveDateTimePicker.Value) : null;
            });

            ProjectArriveDateTimePicker.Enabled = ProjectArriveCheckBox.Checked;

            if (CurrentDelivery?.ProjectArrive == null)
            {
                ProjectArriveDateTimePicker.Value = DateTime.Now;
            }
        }

        private void SetCurrentDeliveryPlantArrive()
        {
            SetCurrentDeliveryProperty(() =>
            {
                CurrentDelivery.PlantArrive = PlantArriveCheckBox.Checked ? new DateTime?(PlantArriveDateTimePicker.Value) : null;
            });

            PlantArriveDateTimePicker.Enabled = PlantArriveCheckBox.Checked;

            if (CurrentDelivery?.PlantArrive == null)
            {
                PlantArriveDateTimePicker.Value = DateTime.Now;
            }
        }

        private void SetCurrentDeliveryStartUnloading()
        {
            SetCurrentDeliveryProperty(() =>
            {
                CurrentDelivery.StartUnloading = StartUnloadingCheckBox.Checked ? new DateTime?(StartUnloadingDateTimePicker.Value) : null;
            });

            StartUnloadingDateTimePicker.Enabled = StartUnloadingCheckBox.Checked;

            if (CurrentDelivery?.StartUnloading == null)
            {
                StartUnloadingDateTimePicker.Value = DateTime.Now;
            }
        }

        private void SetCurrentDeliveryFinishedUnloading()
        {
            SetCurrentDeliveryProperty(() =>
            {
                CurrentDelivery.FinishedUnloading = FinishedUnloadingCheckBox.Checked ? new DateTime?(FinishedUnloadingDateTimePicker.Value) : null;
            });

            FinishedUnloadingDateTimePicker.Enabled = FinishedUnloadingCheckBox.Checked;

            if (CurrentDelivery?.FinishedUnloading == null)
            {
                FinishedUnloadingDateTimePicker.Value = DateTime.Now;
            }
        }

        private void SetCurrentDeliveryEstimatedStay()
        {
            SetCurrentDeliveryProperty(() =>
            {
                CurrentDelivery.EstimatedStay = EstimatedStayCheckBox.Checked ? new DateTime?(EstimatedStayDateTimePicker.Value) : null;
            });

            EstimatedStayDateTimePicker.Enabled = EstimatedStayCheckBox.Checked;

            if (CurrentDelivery?.EstimatedStay == null)
            {
                EstimatedStayDateTimePicker.Value = DateTime.Now;
            }
        }

        private void ProjectArriveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetCurrentDeliveryProjectArrive();
        }

        private void PlantArriveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetCurrentDeliveryPlantArrive();
        }

        private void StartUnloadingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetCurrentDeliveryStartUnloading();
        }

        private void FinishedUnloadingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetCurrentDeliveryFinishedUnloading();
        }

        private void EstimatedStayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetCurrentDeliveryEstimatedStay();
        }

        private void ProjectArriveDateTimePicker_Leave(object sender, EventArgs e)
        {
            SetCurrentDeliveryProjectArrive();
        }

        private void PlantArriveDateTimePicker_Leave(object sender, EventArgs e)
        {
            SetCurrentDeliveryPlantArrive();
        }

        private void StartUnloadingDateTimePicker_Leave(object sender, EventArgs e)
        {
            SetCurrentDeliveryStartUnloading();
        }

        private void FinishedUnloadingDateTimePicker_Leave(object sender, EventArgs e)
        {
            SetCurrentDeliveryFinishedUnloading();
        }

        private void EstimatedStayDateTimePicker_Leave(object sender, EventArgs e)
        {
            SetCurrentDeliveryEstimatedStay();
        }

        private void SearchDeliveryReceiptNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchDeliveryReceiptNumberTimer.Start();
        }

        private void SearchDeliveryReceiptNumberTimer_Tick(object sender, EventArgs e)
        {
            SearchDeliveryReceiptNumberTimer.Stop();
            SearchDeliveryReceiptNumber();
        }

        private void SearchDeliveryReceiptNumber()
        {
            if (string.IsNullOrWhiteSpace(SearchDeliveryReceiptNumberTextBox.Text)) return;
            var key = SearchDeliveryReceiptNumberTextBox.Text.Trim();

            foreach (DataGridViewRow row in DeliveryDataGridView.Rows)
            {
                if (row.Cells[Delivery_DeliveryReceiptNumberColumn.Name].Value as string == key)
                {
                    row.Selected = true;
                }
            }
        }

        private async void FilterByDeliveryDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            await GetUnbilledDeliveryListAsync();
        }

        private async void FilterByDeliveryDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            await GetUnbilledDeliveryListAsync();
        }
    }
}
