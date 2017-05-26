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
            DeliveryDateTextBox.Text = value?.DeliveryDate.ToString("#,##0.00");
            DeliveredVolumeTextBox.Text = value?.Volume.ToString("#,##0.00");
            RouteTextBox.Text = value?.Route?.ToString();
            PlantTextBox.Text = value?.Branch?.ToString();
            DriverTextBox.Text = value?.Driver?.ToString();
            TransitMixerTextBox.Text = value?.TransitMixer?.ToString();
            AdmixtureTextBox.Text = value?.Admixture;
            AdmixtureQuantityTextBox.Text = value?.AdmixtureQuantity.ToString("#,##0.00");
            PlantLeaveTextBox.Text = value?.PlantLeave?.ToString("MMM, d, yyyy");
            LoadTextBox.Text = value?.Load;
            MaxSlumpTextBox.Text = value?.MaxSlump.ToString("#,##0.00");
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

        private void DeliveryDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DeliveryDataGridView.SelectedRows.Count == 1 && DeliveryDataGridView.SelectedRows[0].Cells[DeliveryColumn.Name].Value is Delivery delivery)
            {
                CurrentDelivery = delivery;
            }
        }

        private void ConfirmDeliveryButton_Click(object sender, EventArgs e)
        {

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
        }

        private void SetCurrentDeliveryPlantArrive()
        {
            SetCurrentDeliveryProperty(() =>
            {
                CurrentDelivery.PlantArrive = PlantArriveCheckBox.Checked ? new DateTime?(PlantArriveDateTimePicker.Value) : null;
            });
        }

        private void SetCurrentDeliveryStartUnloading()
        {
            SetCurrentDeliveryProperty(() =>
            {
                CurrentDelivery.StartUnloading = StartUnloadingCheckBox.Checked ? new DateTime?(StartUnloadingDateTimePicker.Value) : null;
            });
        }

        private void SetCurrentDeliveryFinishedUnloading()
        {
            SetCurrentDeliveryProperty(() =>
            {
                CurrentDelivery.FinishedUnloading = FinishedUnloadingCheckBox.Checked ? new DateTime?(FinishedUnloadingDateTimePicker.Value) : null;
            });
        }

        private void SetCurrentDeliveryEstimatedStay()
        {
            SetCurrentDeliveryProperty(() =>
            {
                CurrentDelivery.EstimatedStay = EstimatedStayCheckBox.Checked ? new DateTime?(EstimatedStayDateTimePicker.Value) : null;
            });
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
    }
}
