using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.ReceivablesIntegration.Forms
{
    public partial class PurchaseOrderManagementForm : Form
    {
        public PurchaseOrderManagementForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async Task GetClientListAsync()
        {
            cmbxClient.Items.Clear();

            try
            {
                var clients = await ClientManager.GetListWithApprovedProjectDesignAsync();

                if (clients != null)
                {
                    cmbxClient.Items.AddRange(clients.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetProjectListByClientAsync()
        {
            cmbxProject.Items.Clear();

            var client = cmbxClient.SelectedItem as Client;

            if (client != null)
            {
                try
                {
                    var projects = await ProjectManager.GetListWithApprovedProjectDesignByClientAsync(client);

                    if (projects != null)
                    {
                        cmbxProject.Items.AddRange(projects.ToArray());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task GetProjectDesignListByProjectAsync()
        {
            dgvProjectDesign.Rows.Clear();
            dgvPurchaseOrderProjectDesign.Rows.Clear();

            var project = cmbxProject.SelectedItem as Project;

            if (project != null)
            {
                try
                {
                    var projectDesigns = await ProjectDesignManager.GetApprovedListByProjectAsync(project);

                    if (projectDesigns != null)
                    {
                        foreach (var projectDesign in projectDesigns)
                        {
                            AddProjectDesignToUI(projectDesign);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task SaveAsync()
        {
            var project = cmbxProject.SelectedItem as Project;

            if (project != null)
            {
                if (dgvPurchaseOrderProjectDesign.Rows.Count > 0)
                {
                    var purchaseOrderNumber = nudPurchaseOrderNumber.Value.ToString("#,##0");

                    if (await PurchaseOrderManager.NumberExistsAsync(purchaseOrderNumber))
                    {
                        MessageBox.Show("Purchase Order No. is already in used.");
                    }
                    else
                    {
                        var purchaseOrder = new PurchaseOrder();
                        purchaseOrder.Project = project;
                        purchaseOrder.Number = purchaseOrderNumber;
                        purchaseOrder.Balance = nudInitialBalance.Value;

                        var purchaseOrderTransaction = new PurchaseOrderTransaction();
                        purchaseOrderTransaction.PurchaseOrder = purchaseOrder;

                        foreach (DataGridViewRow row in dgvPurchaseOrderProjectDesign.Rows)
                        {
                            purchaseOrderTransaction.PurchaseOrderProjectDesigns.Add(row.Cells[colPurchaseOrderProjectDesign.Name].Value as PurchaseOrderProjectDesign);
                        }

                        try
                        {
                            purchaseOrderTransaction = await PurchaseOrderTransactionManager.InsertAsync(purchaseOrderTransaction);

                            if (purchaseOrderTransaction != null)
                            {
                                MessageBox.Show("Purchase order saved successfully.");
                                cmbxClient.SelectedItem = null;
                                dgvProjectDesign.Rows.Clear();
                                dgvPurchaseOrderProjectDesign.Rows.Clear();
                                nudPurchaseOrderNumber.Value = 0;
                                nudInitialBalance.Value = 0;
                            }
                            else
                            {
                                MessageBox.Show("Failed on saving purchase order.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nothing to save.");
                }
            }
            else
            {
                MessageBox.Show("Invalid project.");
            }
        }

        private void AddProjectDesignToUI(ProjectDesign projectDesign)
        {
            var row = new DataGridViewRow();
            row.Height = 30;
            
            row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign });

            dgvProjectDesign.Rows.Add(row);
        }

        private void IncludeProjectDesign()
        {
            if (dgvProjectDesign.SelectedRows.Count == 1)
            {
                var selectedRow = dgvProjectDesign.SelectedRows[0];
                var projectDesign = selectedRow.Cells[colProjectDesign.Name].Value as ProjectDesign;

                if (projectDesign != null)
                {
                    if (nudMaxVolume.Value > 0)
                    {
                        var purchaseOrderProjectDesign = new PurchaseOrderProjectDesign();
                        purchaseOrderProjectDesign.ProjectDesign = projectDesign;
                        purchaseOrderProjectDesign.MaxVolume = nudMaxVolume.Value;

                        AddPurchaseOrderProjectDesignToUI(purchaseOrderProjectDesign);
                        dgvProjectDesign.Rows.Remove(selectedRow);
                        nudMaxVolume.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Max Volume seems invalid.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid project design.");
                }
            }
            else
            {
                MessageBox.Show("No Selected Project Design to include.");
            }
        }

        private void ExcludeProjectDesign()
        {
            if (dgvPurchaseOrderProjectDesign.SelectedRows.Count == 1)
            {
                var selectedRow = dgvPurchaseOrderProjectDesign.SelectedRows[0];
                var purchaseOrderProjectDesign = selectedRow.Cells[colPurchaseOrderProjectDesign.Name].Value as PurchaseOrderProjectDesign;

                if (purchaseOrderProjectDesign != null)
                {
                    AddProjectDesignToUI(purchaseOrderProjectDesign.ProjectDesign);
                    dgvPurchaseOrderProjectDesign.Rows.Remove(selectedRow);
                }
                else
                {
                    MessageBox.Show("Invalid project design.");
                }
            }
            else
            {
                MessageBox.Show("No Selected Project Design to exclude.");
            }
        }

        private void AddPurchaseOrderProjectDesignToUI(PurchaseOrderProjectDesign purchaseOrderProjectDesign)
        {
            var row = new DataGridViewRow();
            row.Height = 30;

            row.Cells.Add(new DataGridViewTextBoxCell { Value = purchaseOrderProjectDesign });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = purchaseOrderProjectDesign.ProjectDesign });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = purchaseOrderProjectDesign.MaxVolume });

            dgvPurchaseOrderProjectDesign.Rows.Add(row);
        }

        private async void PurchaseOrderManagementForm_Load(object sender, EventArgs e)
        {
            await GetClientListAsync();
        }

        private async void cmbxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetProjectListByClientAsync();
        }

        private async void cmbxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetProjectDesignListByProjectAsync();
        }

        private void btnIncludeProjectDesign_Click(object sender, EventArgs e)
        {
            IncludeProjectDesign();
        }

        private void btnExcludeProjectDesign_Click(object sender, EventArgs e)
        {
            ExcludeProjectDesign();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await SaveAsync();
        }
    }
}
