using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Citicon.Data;
using Citicon.DataManager;
using System.Linq;

namespace Citicon.Forms.Controls
{
    public partial class DeliveryManagement : UserControl
    {
        public DeliveryManagement()
        {
            InitializeComponent();
            RouteManager = new DeliveryRouteManager();
            TransitMixerManager = new TransitMixerManager();
        }

        public event EventHandler CloseDialogRequested;
        private DeliveryRouteManager RouteManager;
        private TransitMixerManager TransitMixerManager;

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

        private async Task GetTransitMixerListAsync()
        {
            Delivery_TransitMixerTextBox.Items.Clear();

            try
            {
                var transitMixers = await TransitMixerManager.GetListAsync();

                if (transitMixers != null && transitMixers.Any())
                {
                    Delivery_TransitMixerTextBox.Items.AddRange(transitMixers.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);long a = 1_000;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Do you really want to cancel delivery?", "Delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                CloseDialogRequested?.Invoke(this, new EventArgs());
            }
        }

        private async void DeliveryManagement_Load(object sender, EventArgs e)
        {
            await GetDeliveryRouteListAsync();
            await GetDriverListAsync();
            await GetTransitMixerListAsync();
        }

        private void Delivery_DriverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
