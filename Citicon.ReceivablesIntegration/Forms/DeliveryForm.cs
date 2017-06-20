using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.ReceivablesIntegration.Forms
{
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
            ScheduledProjectDesignManager = new ScheduledProjectDesignManager();
        }

        private ScheduledProjectDesignManager ScheduledProjectDesignManager;

        private async Task GetScheduledListAsync()
        {
            dgvScheduledProjectDesign.Rows.Clear();

            try
            {
                var scheduledList = await ScheduledProjectDesignManager.GetListAsync(DateTime.Now, ScheduledProjectDesignStatus.FinalApproved);

                if (scheduledList != null)
                {
                    foreach (var item in scheduledList)
                    {
                        AddScheduledProjectDesign(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddScheduledProjectDesign(ScheduledProjectDesign scheduledProjectDesign)
        {
            if (scheduledProjectDesign != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = scheduledProjectDesign });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = scheduledProjectDesign.Design });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = scheduledProjectDesign.Design?.Project });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = scheduledProjectDesign.Design?.Quotation?.Agent });
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
                    var form = new DeliveryManagementForm(scheduledProjectDesign.Design);
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
            await GetScheduledListAsync();
        }

        private async void BtnConfirmDelivery_Click(object sender, EventArgs e)
        {
            ConfirmDelivery();
            await GetScheduledListAsync();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
