using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
            ScheduledProjectDesignManager = new ScheduledProjectDesignManager();
        }

        private ScheduledProjectDesignManager ScheduledProjectDesignManager;

        private async Task GetClientListAsync()
        {
            ClientDataGridView.Rows.Clear();

            try
            {
                var clients = await ClientManager.GetListWithScheduledProjectDesignAsync(DateTime.Now, ScheduledProjectDesignStatus.FinalApproved);

                if (clients != null)
                {
                    foreach (var client in clients)
                    {
                        AddToUI(client);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetProjectListAsync()
        {
            ProjectDataGridView.Rows.Clear();

            if (ClientDataGridView.SelectedRows.Count == 1)
            {
                try
                {
                    var client = ClientDataGridView.SelectedRows[0].Cells[ClientColumn.Name].Value as Client;
                    var projects = await ProjectManager.GetListWithScheduledProjectDesignByClientAsync(client, DateTime.Now, ScheduledProjectDesignStatus.FinalApproved);

                    if (projects != null)
                    {
                        foreach (var project in projects)
                        {
                            AddToUI(project);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task GetScheduledProjectDesignListAsync()
        {
            dgvScheduledProjectDesign.Rows.Clear();

            if (ProjectDataGridView.SelectedRows.Count == 1)
            {
                try
                {
                    var project = ProjectDataGridView.SelectedRows[0].Cells[ProjectColumn.Name].Value as Project;
                    var scheduledProjectDesigns = await ScheduledProjectDesignManager.GetListByProjectAsync(project, DateTime.Now, ScheduledProjectDesignStatus.FinalApproved);

                    if (scheduledProjectDesigns != null)
                    {
                        foreach (var scheduledProjectDesign in scheduledProjectDesigns)
                        {
                            AddToUI(scheduledProjectDesign);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddToUI(Project project)
        {
            if (project != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = project });
                ProjectDataGridView.Rows.Add(row);
            }
        }

        private void AddToUI(Client client)
        {
            if (client != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = client });
                ClientDataGridView.Rows.Add(row);
            }
        }

        private void AddToUI(ScheduledProjectDesign scheduledProjectDesign)
        {
            if (scheduledProjectDesign != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = scheduledProjectDesign });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = scheduledProjectDesign.Design });
                //row.Cells.Add(new DataGridViewTextBoxCell { Value = scheduledProjectDesign.Design?.Project });
                //row.Cells.Add(new DataGridViewTextBoxCell { Value = scheduledProjectDesign.Design?.Quotation?.Agent });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = scheduledProjectDesign.Design?.PurchaseOrder });

                dgvScheduledProjectDesign.Rows.Add(row);
            }
        }

        private void DisplaySelectedScheduledDesign()
        {
            if (dgvScheduledProjectDesign.SelectedRows.Count == 1)
            {
                var scheduledProjectDesign = (ScheduledProjectDesign)dgvScheduledProjectDesign.SelectedRows[0].Cells[colScheduledProjectDesign.Name].Value;
                DisplayScheduledDesign(scheduledProjectDesign);
            }
        }

        private void DisplayScheduledDesign(ScheduledProjectDesign scheduledDesign)
        {
            tbxProjectDesignDetails_Aggregate.Text = string.Empty;
            tbxProjectDesignDetails_CementFactor.Text = string.Empty;
            tbxProjectDesignDetails_InitialVolume.Text = string.Empty;
            tbxProjectDesignDetails_MixType.Text = string.Empty;
            tbxProjectDesignDetails_PricePerCubicMeter.Text = string.Empty;
            tbxProjectDesignDetails_Project.Text = string.Empty;
            tbxProjectDesignDetails_Project_Client.Text = string.Empty;
            tbxProjectDesignDetails_Psi.Text = string.Empty;
            tbxProjectDesignDetails_Strength.Text = string.Empty;

            if (scheduledDesign != null)
            {
                tbxProjectDesignDetails_Aggregate.Text = scheduledDesign.Design?.Aggregate?.ToString();
                tbxProjectDesignDetails_CementFactor.Text = scheduledDesign.Design?.CementFactor.ToString("#,##0.###");
                tbxProjectDesignDetails_InitialVolume.Text = scheduledDesign.Design?.InitialVolume.ToString("#,##0.###");
                tbxProjectDesignDetails_MixType.Text = scheduledDesign.Design?.MixType.ToString();
                tbxProjectDesignDetails_PricePerCubicMeter.Text = scheduledDesign.Design?.PricePerCubicMeter.ToString("#,##0.00");
                tbxProjectDesignDetails_Project.Text = scheduledDesign.Design?.Project?.ToString();
                tbxProjectDesignDetails_Project_Client.Text = scheduledDesign.Design?.Project?.Client?.ToString();
                tbxProjectDesignDetails_Psi.Text = scheduledDesign.Design?.Psi.ToString("#,##0.###");
                tbxProjectDesignDetails_Strength.Text = scheduledDesign.Design?.Strength?.ToString();
            }
        }

        private void ConfirmDelivery()
        {
            if (dgvScheduledProjectDesign.SelectedRows.Count == 1)
            {
                if (dgvScheduledProjectDesign.SelectedRows[0].Cells[colScheduledProjectDesign.Name].Value is ScheduledProjectDesign scheduledProjectDesign)
                {
                    var form = new DeliveryManagementForm(scheduledProjectDesign.Design, DeliveryScheduleStatus.Scheduled);
                    form.ShowDialog();
                    form = null;
                    //var personnelIds = new List<int>();

                    //foreach (DataGridViewRow row in dgvPersonnel.Rows)
                    //{
                    //    if ((bool)row.Cells[colPersonnel_Selected.Name].Value)
                    //    {
                    //        var personnel = (Employee)row.Cells[colPersonnel.Name].Value;

                    //        personnelIds.Add((int)personnel.Id);
                    //    }
                    //}

                    //frmConfirm_Delivery.projectId = (int)scheduledProjectDesign.Design.Project.Id;
                    //frmConfirm_Delivery.clientId = (int)scheduledProjectDesign.Design.Project.Client.Id;
                    //frmConfirm_Delivery.projectDesignId = (int)scheduledProjectDesign.Design.Id;
                    //frmConfirm_Delivery.pricePerCubic = (double)scheduledProjectDesign.Design.PricePerCubicMeter;
                    //frmConfirm_Delivery.personnelList = personnelIds;

                    //var form = new frmConfirm_Delivery(scheduledProjectDesign.Design);
                    //form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nothing is selected.");
                }
            }
        }

        private void DgvScheduledProjectDesign_SelectionChanged(object sender, EventArgs e)
        {
            DisplaySelectedScheduledDesign();
        }

        private async void DeliveryForm_Load(object sender, EventArgs e)
        {
            await GetClientListAsync();
            //await GetScheduledListAsync();
        }

        private async void BtnConfirmDelivery_Click(object sender, EventArgs e)
        {
            ConfirmDelivery();
            await GetClientListAsync();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gbxProjectDesignDetails_Enter(object sender, EventArgs e)
        {

        }

        private void dgvScheduledProjectDesign_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ClientDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await GetProjectListAsync();
        }

        private async void ProjectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await GetScheduledProjectDesignListAsync();
        }

        private async void ReprintDeliveryReceiptButton_Click(object sender, EventArgs e)
        {
            await ReprintDeliveryReceiptAsync();
        }

        private async Task ReprintDeliveryReceiptAsync()
        {
            if (string.IsNullOrWhiteSpace(ReprintDeliveryReceiptTextBox.Text))
            {
                MessageBox.Show("DR No. is invalid.");
            }
            else
            {
                var delivery = await DeliveryManager.GetDeliveryByNumberAsync(ReprintDeliveryReceiptTextBox.Text.Trim());

                if (delivery != null)
                {
                    await DeliveryManager.ExportDeliveryReceiptAsync(delivery, true);
                }
                else
                {
                    MessageBox.Show("DR not found!");
                }
            }
        }
    }
}
