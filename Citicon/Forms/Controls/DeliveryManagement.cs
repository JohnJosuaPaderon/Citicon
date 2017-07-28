using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.Dialogs;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms.Controls
{
    public partial class DeliveryManagement : UserControl
    {
        public DeliveryManagement()
        {
            InitializeComponent();
            RouteManager = new DeliveryRouteManager();
            TransitMixerManager = new TransitMixerManager();
            BranchManager = new BranchManager();
            ScheduledProjectDesignManager = new ScheduledProjectDesignManager();
        }

        public event EventHandler CloseDialogRequested;
        private DeliveryRouteManager RouteManager;
        private BranchManager BranchManager;
        private TransitMixerManager TransitMixerManager;
        private ScheduledProjectDesignManager ScheduledProjectDesignManager;

        private ulong LatestDeliveryReceiptNumber { get; set; }
        public Delivery Delivery { get; private set; }

        private DeliveryAutoValues _AutoValues;

        private DeliveryAutoValues AutoValues
        {
            get { return _AutoValues; }
            set
            {
                _AutoValues = value;
                LoadNumericUpDown.Value = value?.Load ?? 1;
                ComputeCumulativeVolume();
            }
        }

        private void ComputeCumulativeVolume()
        {
            CumulativeVolumeNumericUpDown.Value = (AutoValues?.CumulativeVolume ?? 0) + Delivery_DeliveredVolumeNumericUpDown.Value;
        }

        private DeliveryScheduleStatus _DeliveryScheduleStatus;

        public DeliveryScheduleStatus DeliveryScheduleStatus
        {
            get { return _DeliveryScheduleStatus; }
            set
            {
                _DeliveryScheduleStatus = value;
            }
        }

        private ProjectDesign _ProjectDesign;

        public ProjectDesign ProjectDesign
        {
            get { return _ProjectDesign; }
            set
            {
                _ProjectDesign = value;
                OnProjectDesignChanged();
            }
        }

        private PurchaseOrder _PurchaseOrder;

        public PurchaseOrder PurchaseOrder
        {
            get { return _PurchaseOrder; }
            set
            {
                _PurchaseOrder = value;
                OnPurchaseOrder();
            }
        }

        private void OnPurchaseOrder()
        {
            PurchaseOrderTextBox.BackColor = Color.White;
            PurchaseOrderTextBox.Text = PurchaseOrder?.Number ?? "<No P.O.>";
            PurchaseOrder_MaximumCumulativePricePerCubicMeterTextBox.Text = PurchaseOrder?.MaximumCumulativePricePerCubicMeter.ToString("#,##0.00") ?? "N/A";

            if (PurchaseOrder != null && PurchaseOrder.WarningLevelReached)
            {
                PurchaseOrderWarningTimer.Start();
                MessageBox.Show("P.O.'s Maximum Cumulative Price/Cu.M. is nearly to be consumed.", "P.O. Monitoring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PurchaseOrderWarningTimer.Stop();
            }
        }

        private void OnProjectDesignChanged()
        {
            Project_ClientTextBox.Text = ProjectDesign?.Project?.Client?.CompanyName;
            Project_Client_AddressTextBox.Text = ProjectDesign?.Project?.Client?.Address;
            Project_NameTextBox.Text = ProjectDesign?.Project?.Name;
            Project_LocationTextBox.Text = ProjectDesign?.Project?.Location;
            Design_MixTypeTextBox.Text = ProjectDesign?.MixType.ToString();
            Design_PsiTextBox.Text = (ProjectDesign?.Psi ?? 0).ToString("#,##0.0##");
            Design_InitialVolumeTextBox.Text = (ProjectDesign?.InitialVolume ?? 0).ToString("#,##0.0##");
            Design_AggregateTextBox.Text = ProjectDesign?.Aggregate?.Value;
            Design_StrengthTextBox.Text = ProjectDesign?.Strength?.Value;
            Design_CementFactorTextBox.Text = (ProjectDesign?.CementFactor ?? 0).ToString("#,##0.0##");
        }

        private async Task GetDeliveryRouteListAsync()
        {
            Delivery_RouteComboBox.Items.Clear();

            try
            {
                var deliveries = await RouteManager.GetListAsync();

                if (deliveries != null && deliveries.Any())
                {
                    Delivery_RouteComboBox.Items.AddRange(deliveries.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetDriverListAsync()
        {
            Delivery_DriverComboBox.Items.Clear();

            try
            {
                var drivers = await EmployeeManager.GetDriverListAsync();

                if (drivers != null && drivers.Any())
                {
                    Delivery_DriverComboBox.Items.AddRange(drivers.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetServiceEngineerListAsync()
        {
            ServiceEngineerComboBox.Items.Clear();

            try
            {
                var serviceEngineers = await EmployeeManager.GetServiceEngineerListAsync();

                if (serviceEngineers != null && serviceEngineers.Any())
                {
                    ServiceEngineerComboBox.Items.AddRange(serviceEngineers.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetBranchListAsync()
        {
            Delivery_PlantComboBox.Items.Clear();

            try
            {
                var branches = await BranchManager.GetListAsync();

                if (branches != null && branches.Any())
                {
                    Delivery_PlantComboBox.Items.AddRange(branches.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetLatestDeliveryReceiptNumberAsync()
        {
            DeliveryReceiptNumberTextBox.Text = string.Empty;

            try
            {
                Delivery.DeliveryReceiptNumber = await DeliveryManager.GetLatestDeliveryReceiptNumberAsync(Delivery.DeliveryDate);
                DeliveryReceiptNumberTextBox.Text = Delivery.DeliveryReceiptNumberDisplay;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetMaxScheduledVolumeAsync()
        {
            MaxScheduledVolumeTextBox.Text = "No Max. Scheduled Volume";

            try
            {
                var maxVolume = await ScheduledProjectDesignManager.GetMaximumVolumeByProjectDesignAndDeliveryDateAsync(ProjectDesign, Delivery_DeliveryDateTimePicker.Value);
                MaxScheduledVolumeTextBox.Text = maxVolume.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetTransitMixerListAsync()
        {
            Delivery_TransitMixerComboBox.Items.Clear();

            try
            {
                var transitMixers = await TransitMixerManager.GetListAsync();

                if (transitMixers != null && transitMixers.Any())
                {
                    Delivery_TransitMixerComboBox.Items.AddRange(transitMixers.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetAutoValuesAsync()
        {
            try
            {
                AutoValues = await DeliveryManager.GetAutoValuesAsync(ProjectDesign, Delivery_DeliveryDateTimePicker.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetPurchaseOrderAsync()
        {
            try
            {
                var purchaseOrderProjectDesign = await PurchaseOrderProjectDesignManager.GetAvailableAsync(ProjectDesign);

                if (purchaseOrderProjectDesign != null)
                {
                    PurchaseOrder_MaximumVolumeTextBox.Text = purchaseOrderProjectDesign.MaxVolume.ToString("#,##0.0##");
                    PurchaseOrder = purchaseOrderProjectDesign.PurchaseOrder;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Do you really want to cancel delivery?", "Delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                OnCloseDialogRequested();
            }
        }

        private void OnCloseDialogRequested()
        {
            CloseDialogRequested?.Invoke(this, new EventArgs());
        }

        private async void DeliveryManagement_Load(object sender, EventArgs e)
        {
            Delivery = new Delivery();

            Delivery_DeliveryDateTimePicker.Value = DateTime.Now;

            await GetDeliveryRouteListAsync();
            await GetDriverListAsync();
            await GetServiceEngineerListAsync();
            await GetTransitMixerListAsync();
            await GetBranchListAsync();
            await GetPurchaseOrderAsync();
            await GetLatestDeliveryReceiptNumberAsync();
            await GetMaxScheduledVolumeAsync();
            SetDeliveryAdmixture();
            SetDeliveryAdmixtureQuantity();
            SetDeliveryDeliveredVolume();
            await SetDeliveryDeliveryDateAsync();
            SetDeliveryDriver();
            SetDeliveryPlantLeave();
            SetDeliveryRoute();
            SetDeliveryTransitMixer();
            await GetAutoValuesAsync();

            Delivery.Project = ProjectDesign.Project;
            Delivery.ProjectDesign = ProjectDesign;
            Delivery.PurchaseOrder = PurchaseOrder;
            Delivery.ScheduleStatus = DeliveryScheduleStatus;
        }

        private void Delivery_DriverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDeliveryDriver();
        }

        private void SetDeliveryDriver()
        {
            var driver = Delivery_DriverComboBox.SelectedItem as Employee;
            if (Delivery.Driver != driver)
            {
                Delivery.Driver = driver;
            }
        }

        private async void DeliveryReceiptRefreshButton_Click(object sender, EventArgs e)
        {
            await GetLatestDeliveryReceiptNumberAsync();
        }

        private void Delivery_DeliveryDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Delivery_DeliveryDateCheckBox.Checked)
            {
                Delivery_DeliveryDateCheckBox.Text = "Delivery Date (Auto)";
                Delivery_DeliveryDateTimePicker.Enabled = false;
                Delivery_DeliveryDateTimePicker.Value = DateTime.Now.Date;
            }
            else
            {
                Delivery_DeliveryDateCheckBox.Text = "Delivery Date (Manual)";
                Delivery_DeliveryDateTimePicker.Enabled = true;
            }
        }

        private async void SaveDeliveryButton_Click(object sender, EventArgs e)
        {
            try
            {
                Delivery.ServiceEngineer = ServiceEngineerComboBox.SelectedItem as Employee;
                Delivery.PricePerCubicMeter = ProjectDesign?.PricePerCubicMeter ?? 0;
                Delivery.AdmixtureQuantity = Delivery_AdmixtureQuantityTextBox.Text;
                Delivery.Load = Convert.ToUInt32(LoadNumericUpDown.Value);
                Delivery.CumulativeVolume = CumulativeVolumeNumericUpDown.Value;
                var delivery = await DeliveryManager.InsertAsync(Delivery);
                if (delivery != null)
                {
                    MessageBox.Show("Successfully delivered.");
                    await DeliveryManager.ExportDeliveryReceiptAsync(delivery);
                    OnCloseDialogRequested();
                }
                else
                {
                    MessageBox.Show("Failed to deliver.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void Delivery_DeliveryDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            await SetDeliveryDeliveryDateAsync();
        }

        private async Task SetDeliveryDeliveryDateAsync()
        {
            if (Delivery.DeliveryDate != Delivery_DeliveryDateTimePicker.Value)
            {
                Delivery.DeliveryDate = Delivery_DeliveryDateTimePicker.Value;

                if (Delivery.DeliveryDate.Year != Delivery_DeliveryDateTimePicker.Value.Year)
                {
                    await GetLatestDeliveryReceiptNumberAsync();
                }
            }
        }

        private void Delivery_DeliveredVolumeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SetDeliveryDeliveredVolume();
        }

        private void SetDeliveryDeliveredVolume()
        {
            if (Delivery.Volume != Delivery_DeliveredVolumeNumericUpDown.Value)
            {
                ComputeCumulativeVolume();
                Delivery.Volume = Delivery_DeliveredVolumeNumericUpDown.Value;
            }
        }

        private void Delivery_RouteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDeliveryRoute();
        }

        private void SetDeliveryRoute()
        {
            var route = Delivery_RouteComboBox.SelectedItem as DeliveryRoute;
            if (Delivery.Route != route)
            {
                Delivery.Route = route;
            }
        }

        private void Delivery_PlantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var branch = Delivery_PlantComboBox.SelectedItem as Branch;
            if (Delivery.Branch != branch)
            {
                Delivery.Branch = branch;
            }
        }

        private void Delivery_TransitMixerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDeliveryTransitMixer();
        }

        private void SetDeliveryTransitMixer()
        {
            var transitMixer = Delivery_TransitMixerComboBox.SelectedItem as TransitMixer;
            if (Delivery.TransitMixer != transitMixer)
            {
                Delivery.TransitMixer = transitMixer;
            }
        }

        private void Delivery_AdmixtureTextBox_TextChanged(object sender, EventArgs e)
        {
            SetDeliveryAdmixture();
        }

        private void SetDeliveryAdmixture()
        {
            if (Delivery.Admixture != Delivery_AdmixtureTextBox.Text)
            {
                Delivery.Admixture = Delivery_AdmixtureTextBox.Text;
            }
        }

        private void Delivery_AdmixtureQuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SetDeliveryAdmixtureQuantity();
        }

        private void SetDeliveryAdmixtureQuantity()
        {
            if (Delivery.AdmixtureQuantity != Delivery_AdmixtureQuantityTextBox.Text)
            {
                Delivery.AdmixtureQuantity = Delivery_AdmixtureQuantityTextBox.Text;
            }
        }

        private void Delivery_PlantLeaveDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SetDeliveryPlantLeave();
        }

        private void SetDeliveryPlantLeave()
        {
            if (Delivery.PlantLeave != Delivery_PlantLeaveDateTimePicker.Value)
            {
                Delivery.PlantLeave = Delivery_PlantLeaveDateTimePicker.Value;
            }
        }

        private void PurchaseOrderWarningTimer_Tick(object sender, EventArgs e)
        {
            if (PurchaseOrderTextBox.BackColor == Color.White)
            {
                PurchaseOrderTextBox.BackColor = Color.Red;
                PurchaseOrderTextBox.ForeColor = Color.White;
            }
            else
            {
                PurchaseOrderTextBox.BackColor = Color.White;
                PurchaseOrderTextBox.ForeColor = Color.Black;
            }
        }

        private void NewRouteButton_Click(object sender, EventArgs e)
        {
            var route = AddEditRouteDialog.AddRoute();

            if (route != null)
            {
                if (!Delivery_RouteComboBox.Items.Contains(route))
                {
                    Delivery_RouteComboBox.Items.Add(route);
                }

                Delivery_RouteComboBox.SelectedItem = route;
            }
        }
    }
}
