﻿using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class PurchaseOrderManagementForm : Form
    {
        private IEnumerable<Client> Clients { get; set; }
        private IEnumerable<Project> Projects { get; set; }
        private User Verifier;

        public PurchaseOrderManagementForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async Task GetClientListAsync()
        {
            cmbxClient.Items.Clear();

            try
            {
                Clients = await ClientManager.GetListWithApprovedProjectDesignAsync();

                if (Clients != null)
                {
                    cmbxClient.Items.AddRange(Clients.ToArray());
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

            if (cmbxClient.SelectedItem is Client client)
            {
                try
                {
                    Projects = await ProjectManager.GetListWithApprovedProjectDesignByClientAsync(client);

                    if (Projects != null)
                    {
                        cmbxProject.Items.AddRange(Projects.ToArray());
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


            if (cmbxProject.SelectedItem is Project project)
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
            if (cmbxProject.SelectedItem is Project project)
            {
                if (dgvPurchaseOrderProjectDesign.Rows.Count > 0)
                {
                    var purchaseOrderNumber = nudPurchaseOrderNumber.Value.ToString();

                    if (await PurchaseOrderManager.NumberExistsAsync(purchaseOrderNumber))
                    {
                        MessageBox.Show("Purchase Order No. is already in used.");
                    }
                    else
                    {
                        var purchaseOrder = new PurchaseOrder()
                        {
                            Project = project,
                            Number = purchaseOrderNumber,
                            MaximumCumulativePricePerCubicMeter = nudMaximumCumulativePricePerCubicMeter.Value,
                            Creator = User.CurrentUser,
                            Verifier = Verifier

                        };
                        var purchaseOrderTransaction = new PurchaseOrderTransaction()
                        {
                            PurchaseOrder = purchaseOrder
                        };
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
                                nudMaximumCumulativePricePerCubicMeter.Value = 0;
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
            var row = new DataGridViewRow()
            {
                Height = 30
            };
            row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign });

            dgvProjectDesign.Rows.Add(row);
        }

        private void IncludeProjectDesign()
        {
            if (dgvProjectDesign.SelectedRows.Count == 1)
            {
                var selectedRow = dgvProjectDesign.SelectedRows[0];

                if (selectedRow.Cells[colProjectDesign.Name].Value is ProjectDesign projectDesign)
                {
                    if (nudMaxVolume.Value > 0)
                    {
                        var purchaseOrderProjectDesign = new PurchaseOrderProjectDesign()
                        {
                            ProjectDesign = projectDesign,
                            MaxVolume = nudMaxVolume.Value
                        };
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

                if (selectedRow.Cells[colPurchaseOrderProjectDesign.Name].Value is PurchaseOrderProjectDesign purchaseOrderProjectDesign)
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
            var row = new DataGridViewRow()
            {
                Height = 30
            };
            row.Cells.Add(new DataGridViewTextBoxCell { Value = purchaseOrderProjectDesign });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = purchaseOrderProjectDesign.ProjectDesign });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = purchaseOrderProjectDesign.MaxVolume });

            dgvPurchaseOrderProjectDesign.Rows.Add(row);
        }

        private async void PurchaseOrderManagementForm_Load(object sender, EventArgs e)
        {
            await GetClientListAsync();
        }

        private async void CmbxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetProjectListByClientAsync();
        }

        private async void CmbxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetProjectDesignListByProjectAsync();
        }

        private void BtnIncludeProjectDesign_Click(object sender, EventArgs e)
        {
            IncludeProjectDesign();
        }

        private void BtnExcludeProjectDesign_Click(object sender, EventArgs e)
        {
            ExcludeProjectDesign();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var verification = UserVerificationDialog.VerifyOther();
            if (verification.Verified)
            {
                Verifier = verification.Verifier;
                await SaveAsync();
            }
            else
            {
                MessageBox.Show("User is not verified and Purchase Order will not be saved.");
            }
        }

        private void SearchClientButton_Click(object sender, EventArgs e)
        {
            cmbxClient.SelectedItem = ClientSearchDialog.Show(Clients);
        }

        private void SearchProjectButton_Click(object sender, EventArgs e)
        {
            if (cmbxClient.SelectedItem is Client client)
            {
                cmbxProject.SelectedItem = ProjectSearchDialog.Show(client, Projects);
            }
        }
    }
}
