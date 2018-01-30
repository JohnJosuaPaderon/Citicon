using Citicon.Data;
using Citicon.DataManager;
using Citicon.DataProcess;
using Citicon.Forms.DataLinks;
using Citicon.WindowsForm;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    internal sealed class DeliveryCancellationFormController : FormControllerBase<DeliveryCancellationForm>
    {
        public DeliveryCancellationFormController(DeliveryCancellationForm form) : base(form)
        {
            _Projects = new DataGridViewItemSource<Project>(_Form.ProjectsDataGridView, AddRow, () => _Form.LinkProjectColumn);
            _ProjectDesigns = new DataGridViewItemSource<ProjectDesign>(_Form.ProjectDesignsDataGridView, AddRow, () => _Form.LinkProjectDesignColumn);
            _Deliveries = new DataGridViewItemSource<Delivery>(_Form.DeliveriesDataGridView, AddRow, () => _Form.LinkDeliveryColumn);
            _SearchKey = new ControlProperty<string>(value => _Form.SearchTextBox.Text = value, () => _Form.SearchTextBox.Text);
            _CancellationRemarks = new ControlProperty<string>(value => _Form.CancellationRemarksTextBox.Text = value, () => _Form.CancellationRemarksTextBox.Text);
            _Options = new ComboBoxItemSource<SearchProjectOption>(_Form.SearchComboBox);
            _Options.Add(SearchProjectOption.Name);
            _Options.Add(SearchProjectOption.ClientName);
        }

        private readonly DataGridViewItemSource<Project> _Projects;
        private readonly DataGridViewItemSource<ProjectDesign> _ProjectDesigns;
        private readonly DataGridViewItemSource<Delivery> _Deliveries;
        private readonly ControlProperty<string> _SearchKey;
        private readonly ControlProperty<string> _CancellationRemarks;
        private readonly ComboBoxItemSource<SearchProjectOption> _Options;
        private Delivery CurrentDelivery;

        private DataGridViewRow AddRow(Project project)
        {
            return new DataGridViewRow()
                .SetHeight(30)
                .AddTextBoxCell(project.Client)
                .AddTextBoxCell(project);
        }

        private DataGridViewRow AddRow(ProjectDesign projectDesign)
        {
            return new DataGridViewRow()
                .SetHeight(30)
                .AddTextBoxCell(projectDesign)
                .AddTextBoxCell(projectDesign.Quotation)
                .AddTextBoxCell(projectDesign.PricePerCubicMeter);
        }

        private DataGridViewRow AddRow(Delivery delivery)
        {
            return new DataGridViewRow()
                .SetHeight(30)
                .AddTextBoxCell(delivery)
                .AddTextBoxCell(delivery.Load)
                .AddTextBoxCell(delivery.DeliveryDate)
                .AddTextBoxCell(delivery.PlantLeave)
                .AddTextBoxCell(delivery.DeliveryReceiptNumberDisplay)
                .AddTextBoxCell(delivery.Volume);
        }

        private void ClearDeliveryDetails()
        {
            _Form.LoadTextBox.Text = string.Empty;
            _Form.DeliveryReceiptNumberTextBox.Text = string.Empty;
            _Form.DeliveryDateTextBox.Text = string.Empty;
            _Form.VolumeTextBox.Text = string.Empty;
            _Form.PlantTextBox.Text = string.Empty;
            _Form.PlantLeaveTextBox.Text = string.Empty;
            _Form.RouteTextBox.Text = string.Empty;
            _Form.DriverTextBox.Text = string.Empty;
            _Form.TransitMixerTextBox.Text = string.Empty;
            _Form.MaxSlumpTextBox.Text = string.Empty;
            _Form.AdmixtureTextBox.Text = string.Empty;
            _Form.AdmixtureQuantityTextBox.Text = string.Empty;
        }

        private void ClearCancellationDetails()
        {
            _Form.CancellationRemarksTextBox.Text = string.Empty;
        }

        private void DisplayDeliveryDetails()
        {
            if (CurrentDelivery != null)
            {
                _Form.LoadTextBox.Text = CurrentDelivery.Load.ToString();
                _Form.DeliveryReceiptNumberTextBox.Text = CurrentDelivery.DeliveryReceiptNumberDisplay;
                _Form.DeliveryDateTextBox.Text = CurrentDelivery.DeliveryDate.ToString("MMMM dd, yyyy");
                _Form.VolumeTextBox.Text = CurrentDelivery.Volume.ToString();
                _Form.PlantTextBox.Text = CurrentDelivery.Branch?.Description;
                _Form.PlantLeaveTextBox.Text = CurrentDelivery.PlantLeave?.ToString("HH:mm");
                _Form.RouteTextBox.Text = CurrentDelivery.Route?.ToString();
                _Form.DriverTextBox.Text = CurrentDelivery.Driver?.ToString();
                _Form.TransitMixerTextBox.Text = CurrentDelivery.TransitMixer?.ToString();
                _Form.MaxSlumpTextBox.Text = CurrentDelivery.MaxSlump;
                _Form.AdmixtureTextBox.Text = CurrentDelivery.Admixture;
                _Form.AdmixtureQuantityTextBox.Text = CurrentDelivery.AdmixtureQuantity;
            }
        }

        private void TryRemoveProjectDesign()
        {
            if (_Deliveries.Count <= 0)
            {
                _ProjectDesigns.Remove(_ProjectDesigns.SelectedItem);
                TryRemoveProject();
            }
        }

        private void TryRemoveProject()
        {
            if (_ProjectDesigns.Count <= 0)
            {
                _Projects.Remove(_Projects.SelectedItem);
            }
        }

        public async Task SearchProjectAsync()
        {
            _Projects.Clear();

            try
            {
                var projects = await ProjectManager.SearchWithCancellableDeliveryAsync(_SearchKey.Get(), _Options.SelectedItem);

                if (projects != null && projects.Any())
                {
                    _Projects.AddRange(projects);
                }
            }
            catch (Exception ex)
            {
                _MessageDisplay.Exception(ex);
            }
        }

        public async Task GetProjectDesignsAsync()
        {
            _ProjectDesigns.Clear();
            var selectedProject = _Projects.SelectedItem;

            if (selectedProject != null)
            {
                try
                {
                    var projectDesigns = await ProjectDesignManager.GetListByProjectWithCancellableDeliveryAsync(selectedProject);

                    if (projectDesigns != null && projectDesigns.Any())
                    {
                        _ProjectDesigns.AddRange(projectDesigns);
                    }
                }
                catch (Exception ex)
                {
                    _MessageDisplay.Exception(ex);
                }
            }
        }

        public async Task GetDeliveriesAsync()
        {
            _Deliveries.Clear();
            var selectedProjectDesign = _ProjectDesigns.SelectedItem;

            if (selectedProjectDesign != null)
            {
                try
                {
                    var deliveries = await DeliveryManager.GetCancellableListByProjectDesignAsync(selectedProjectDesign);

                    if (deliveries != null && deliveries.Any())
                    {
                        _Deliveries.AddRange(deliveries);
                    }
                }
                catch (Exception ex)
                {
                    _MessageDisplay.Exception(ex);
                }
            }
        }

        public void DisplayCurrentDelivery()
        {
            CurrentDelivery = _Deliveries.SelectedItem;
            ClearDeliveryDetails();
            DisplayDeliveryDetails();
        }

        public async Task CancelAsync()
        {
            if (CurrentDelivery != null)
            {
                var cancelledDelivery = await DeliveryManager.CancelAsync(CurrentDelivery, DateTime.Now, _CancellationRemarks.Get());

                if (cancelledDelivery != null)
                {
                    _MessageDisplay.Inform("Delivery Cancelled Successfully.");
                    _Deliveries.Remove(_Deliveries.SelectedItem);
                    TryRemoveProjectDesign();
                    ClearCancellationDetails();
                }
                else
                {
                    _MessageDisplay.Error("Failed to cancel delivery.");
                }
            }
            else
            {
                _MessageDisplay.Error("No selected delivery.");
            }
        }
    }
}
