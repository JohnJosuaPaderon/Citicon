using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }
        #region EventHandler : Unsorted
        private void BillingForm_Load(object sender, EventArgs e)
        {
            Parallel.Invoke(
                GetClientList,
                GetStructureTypeList,
                GetPumpSizeList,
                GetPumpTypeList,
                GetAccessoryTypeList,
                GetOtherChargeTypeList);
        }

        private void tbxSearchClient_TextChanged(object sender, EventArgs e)
        {
            SearchClient();
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            GetProjectListByClient();
        }

        private void dgvProjects_SelectionChanged(object sender, EventArgs e)
        {
            GetDeliveryListByProject();
        }
        #endregion

        #region Unsorted
        private void SearchClient()
        {
            if (!string.IsNullOrWhiteSpace(tbxSearchClient.Text))
            {
                var keyword = tbxSearchClient.Text.Trim().ToUpper();
                foreach (DataGridViewRow row in dgvClients.Rows)
                {
                    var client = (Client)row.Cells[colClient.Name].Value;
                    if (client.CompanyName.ToUpper().Contains(keyword))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }
        #endregion

        #region EventHandler : IncludeCharges
        private void ckbxIncludePumpCreteCharges_CheckedChanged(object sender, EventArgs e)
        {
            pnlPumpCreteCharges.Enabled = ckbxIncludePumpCreteCharges.Checked;
        }

        private void ckbxIncludeExcessPipeCharges_CheckedChanged(object sender, EventArgs e)
        {
            pnlExcessPipeCharges.Enabled = ckbxIncludeExcessPipeCharges.Checked;
        }

        private void ckbxIncludeOtherCharges_CheckedChanged(object sender, EventArgs e)
        {
            pnlOtherCharges.Enabled = ckbxIncludeOtherCharges.Checked;
        }
        #endregion

        #region EventHandler : Add
        private void btnPumpcrete_Add_Click(object sender, EventArgs e)
        {
            AddPumpcreteCharge();
            ClearPumpcrete();
        }

        private void btnExcessPipe_Add_Click(object sender, EventArgs e)
        {
            AddExcessPipeCharge();
            ClearExcessPipe();
        }

        private void btnOther_Add_Click(object sender, EventArgs e)
        {
            AddOtherCharge();
            ClearOther();
        }
        #endregion

        #region EventHandler : Cancel
        private void btnPumpcrete_Cancel_Click(object sender, EventArgs e)
        {
            ClearPumpcrete();
        }

        private void btnExcessPipe_Cancel_Click(object sender, EventArgs e)
        {
            ClearExcessPipe();
        }

        private void btnOther_Cancel_Click(object sender, EventArgs e)
        {
            ClearOther();
        }
        #endregion

        #region EventHandler : RemoveAll
        private void btnPumpcrete_RemoveAll_Click(object sender, EventArgs e)
        {
            RemoveAllPumpcreteCharges();
        }

        private void btnExcessPipe_RemoveAll_Click(object sender, EventArgs e)
        {
            RemoveAllExcessPipeCharges();
        }

        private void btnOther_RemoveAll_Click(object sender, EventArgs e)
        {
            RemoveAllOtherCharges();
        }
        #endregion

        #region EventHandler : RemoveSelected
        private void btnPumpcrete_RemoveSelected_Click(object sender, EventArgs e)
        {
            RemoveSelectedPumpcreteCharge();
        }

        private void btnExcessPipe_RemoveSelected_Click(object sender, EventArgs e)
        {
            RemoveSelectedExcessPipeCharge();
        }

        private void btnOther_RemoveSelected_Click(object sender, EventArgs e)
        {
            RemoveSelectedOtherCharge();
        }
        #endregion

        #region EventHandler : Charge.RowsAdded
        private void dgvPumpcreteCharges_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            EnablePumpcreteChargeRemoval();
        }

        private void dgvExcessPipeCharges_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            EnableExcessPipeChargesRemoval();
        }

        private void dgvOtherCharges_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            EnableOtherChargeRemoval();
        }
        #endregion

        #region EventHandler : Charge.RowsRemoved
        private void dgvPumpcreteCharges_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            EnablePumpcreteChargeRemoval();
        }

        private void dgvExcessPipeCharges_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            EnableExcessPipeChargesRemoval();
        }

        private void dgvOtherCharges_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            EnableOtherChargeRemoval();
        }
        #endregion

        #region GetEntityList
        private void GetOtherChargeTypeList()
        {
            var getOtherChargeTypeListTask = OtherChargeTypeManager.GetListAsync();
            getOtherChargeTypeListTask.ContinueWith(DisplayOtherChargeTypeList);
        }

        private void GetAccessoryTypeList()
        {
            var getAccessoryTypeListTask = AccessoryTypeManager.GetListAsync();
            getAccessoryTypeListTask.ContinueWith(DisplayAccessoryTypeList);
        }

        private void GetPumpTypeList()
        {
            var getPumpTypeListTask = PumpTypeManager.GetListAsync();
            getPumpTypeListTask.ContinueWith(DisplayPumpTypeList);
        }

        private void GetPumpSizeList()
        {
            var getPumpSizeListTask = PumpSizeManager.GetListAsync();
            getPumpSizeListTask.ContinueWith(DisplayPumpSizeList);
        }

        private void GetStructureTypeList()
        {
            var getStructureTypeListTask = BillingStructureTypeManager.GetListAsync();
            getStructureTypeListTask.ContinueWith(DisplayStructureTypeList);
        }

        private void GetClientList()
        {
            var getClientListTask = ClientManager.GetListWithUnbilledDeliveryAsync();
            getClientListTask.ContinueWith(DisplayClientList);
        }

        private void GetProjectListByClient()
        {
            if (dgvClients.SelectedRows.Count == 1)
            {
                var client = (Client)dgvClients.SelectedRows[0].Cells[colClient.Name].Value;
                var getProjectListByClientTask = ProjectManager.GetListWithUnbilledDeliveryByClient(client);
                getProjectListByClientTask.ContinueWith(DisplayProjectListByClient);
            }
        }

        private void GetDeliveryListByProject()
        {
            if (dgvProjects.SelectedRows.Count == 1)
            {
                var project = (Project)dgvProjects.SelectedRows[0].Cells[colProject.Name].Value;
                var getDeliveryListByProjectTask = DeliveryManager.GetUnbilledListByProject(project);
                getDeliveryListByProjectTask.ContinueWith(DisplayDeliveryListByProject);
            }
        }
        #endregion

        #region DisplayList
        private void DisplayOtherChargeTypeList(Task<IEnumerable<OtherChargeType>> task)
        {
            Invoke(new Action(() => cmbxOther_OtherChargeType.Items.Clear()));

            if (task.Status == TaskStatus.RanToCompletion)
            {
                Invoke(new Action(() => cmbxOther_OtherChargeType.Items.AddRange(task.Result.ToArray())));
            }
        }

        private void DisplayAccessoryTypeList(Task<IEnumerable<AccessoryType>> task)
        {
            Invoke(new Action(() => cmbxExcessPipe_AccessoryType.Items.Clear()));

            if (task.Status == TaskStatus.RanToCompletion)
            {
                Invoke(new Action(() => cmbxExcessPipe_AccessoryType.Items.AddRange(task.Result.ToArray())));
            }
        }

        private void DisplayPumpTypeList(Task<IEnumerable<PumpType>> task)
        {
            Invoke(new Action(() => cmbxPumpcrete_PumpType.Items.Clear()));

            if (task.Status == TaskStatus.RanToCompletion)
            {
                Invoke(new Action(() => cmbxPumpcrete_PumpType.Items.AddRange(task.Result.ToArray())));
            }
        }

        private void DisplayPumpSizeList(Task<IEnumerable<PumpSize>> task)
        {
            Invoke(new Action(() => cmbxPumpcrete_PumpSize.Items.Clear()));

            if (task.Status == TaskStatus.RanToCompletion)
            {
                Invoke(new Action(() =>
                {
                    cmbxPumpcrete_PumpSize.Items.AddRange(task.Result.ToArray());
                }));
            }
        }

        private void DisplayStructureTypeList(Task<IEnumerable<BillingStructureType>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                Invoke(new Action(() =>
                {
                    cmbxStructureType.Items.Clear();
                    cmbxStructureType.Items.AddRange(task.Result.ToArray());
                }));
            }
        }

        private void DisplayClientList(Task<IEnumerable<Client>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                var rows = new List<DataGridViewRow>();
                if (task.Result != null)
                {
                    foreach (var item in task.Result)
                    {
                        var row = new DataGridViewRow()
                        {
                            Height = 30
                        };
                        row.Cells.AddRange(
                            new DataGridViewTextBoxCell { Value = item },
                            new DataGridViewTextBoxCell { Value = item.Address });

                        rows.Add(row);
                    }
                }

                Invoke(new Action(() =>
                {
                    dgvClients.Rows.Clear();
                    dgvClients.Rows.AddRange(rows.ToArray());
                }));
            }
        }

        private void DisplayProjectListByClient(Task<IEnumerable<Project>> task)
        {
            Invoke(new Action(() => dgvProjects.Rows.Clear()));

            if (task.Status == TaskStatus.RanToCompletion)
            {
                var rows = new List<DataGridViewRow>();

                foreach (var item in task.Result)
                {
                    var row = new DataGridViewRow()
                    {
                        Height = 30
                    };
                    row.Cells.AddRange(
                        new DataGridViewTextBoxCell { Value = item },
                        new DataGridViewTextBoxCell { Value = item.Location });

                    rows.Add(row);
                }

                Invoke(new Action(() => dgvProjects.Rows.AddRange(rows.ToArray())));
            }
        }

        private void DisplayDeliveryListByProject(Task<IEnumerable<Delivery>> task)
        {
            Invoke(new Action(() => dgvDeliveries.Rows.Clear()));

            if (task.Status == TaskStatus.RanToCompletion)
            {
                var rows = new List<DataGridViewRow>();

                foreach (var item in task.Result)
                {
                    var row = new DataGridViewRow()
                    {
                        Height = 30
                    };
                    row.Cells.AddRange(
                        new DataGridViewCheckBoxCell { Value = false },
                        new DataGridViewTextBoxCell { Value = item },
                        new DataGridViewTextBoxCell { Value = item.ProjectDesign },
                        new DataGridViewTextBoxCell { Value = item.DeliveryReceiptNumber },
                        new DataGridViewTextBoxCell { Value = item.PricePerCubicMeter },
                        new DataGridViewTextBoxCell { Value = item.Volume },
                        new DataGridViewTextBoxCell { Value = item.CumulativeVolume });
                    rows.Add(row);
                }

                Invoke(new Action(() => dgvDeliveries.Rows.AddRange(rows.ToArray())));
            }
        }
        #endregion

        #region Clear Entity
        private void ClearPumpcrete()
        {
            tbxPumpcrete_Remarks.Text = string.Empty;
            dtpPumpcrete_OperationTimeFrame_Finish.Value = DateTime.Now;
            dtpPumpcrete_OperationTimeFrame_Start.Value = DateTime.Now;
            cmbxPumpcrete_PumpSize.SelectedItem = null;
            cmbxPumpcrete_PumpType.SelectedItem = null;
            nudPumpcrete_PricePerCubicMeter.Value = 0;
            nudPumpcrete_PricePerSetup.Value = 0;
            nudPumpcrete_TotalVolumePumped.Value = 0;
        }

        private void ClearExcessPipe()
        {
            dtpExcessPipe_OperationTimeFrame_Finish.Value = DateTime.Now;
            dtpExcessPipe_OperationTimeFrame_Start.Value = DateTime.Now;
            cmbxExcessPipe_AccessoryType.SelectedItem = null;
            nudExcessPipe_Amount.Value = 0;
            nudExcessPipe_ChargePerCubicMeter.Value = 0;
            nudExcessPipe_MaximumPieces.Value = 0;
        }

        private void ClearOther()
        {
            cmbxOther_OtherChargeType.SelectedItem = null;
            nudOther_Amount.Value = 0M;
            nudOther_Unit.Value = 0M;
            tbxOther_Remarks.Text = string.Empty;
        }
        #endregion

        #region Add Entity
        private void AddPumpcreteCharge()
        {
            var pumpcreteCharge = new PumpcreteCharge
            {
                Billing = null,
                OperationTimeFrame = new OperationTimeFrame() { Start = dtpPumpcrete_OperationTimeFrame_Start.Value, Finish = dtpPumpcrete_OperationTimeFrame_Finish.Value },
                PricePerCubicMeter = nudPumpcrete_PricePerCubicMeter.Value,
                PricePerSetup = nudPumpcrete_PricePerSetup.Value,
                PumpSize = (PumpSize)cmbxPumpcrete_PumpSize.SelectedItem,
                PumpType = (PumpType)cmbxPumpcrete_PumpType.SelectedItem,
                Remarks = tbxPumpcrete_Remarks.Text,
                TotalVolumePumped = nudPumpcrete_TotalVolumePumped.Value
            };

            var row = new DataGridViewRow()
            {
                Height = 30
            };
            row.Cells.AddRange(
                new DataGridViewTextBoxCell { Value = pumpcreteCharge },
                new DataGridViewTextBoxCell { Value = pumpcreteCharge.PumpType },
                new DataGridViewTextBoxCell { Value = pumpcreteCharge.PumpSize },
                new DataGridViewTextBoxCell { Value = pumpcreteCharge.OperationTimeFrame.Start },
                new DataGridViewTextBoxCell { Value = pumpcreteCharge.OperationTimeFrame.Finish },
                new DataGridViewTextBoxCell { Value = pumpcreteCharge.TotalVolumePumped },
                new DataGridViewTextBoxCell { Value = pumpcreteCharge.PricePerCubicMeter },
                new DataGridViewTextBoxCell { Value = pumpcreteCharge.TotalAmount });

            dgvPumpcreteCharges.Rows.Add(row);
        }

        private void AddExcessPipeCharge()
        {
            var excessPipeCharge = new ExcessPipeCharge()
            {
                AccessoryType = (AccessoryType)cmbxExcessPipe_AccessoryType.SelectedItem,
                Amount = nudExcessPipe_Amount.Value,
                Billing = null,
                ChargePerCubicMeter = nudExcessPipe_ChargePerCubicMeter.Value,
                MaximumCount = (uint)nudExcessPipe_MaximumPieces.Value,
                OperationTimeFrame = new OperationTimeFrame() { Start = dtpExcessPipe_OperationTimeFrame_Start.Value, Finish = dtpExcessPipe_OperationTimeFrame_Finish.Value }
            };
            var row = new DataGridViewRow()
            {
                Height = 30
            };
            row.Cells.AddRange(
                new DataGridViewTextBoxCell { Value = excessPipeCharge },
                new DataGridViewTextBoxCell { Value = excessPipeCharge.AccessoryType },
                new DataGridViewTextBoxCell { Value = excessPipeCharge.OperationTimeFrame.Start },
                new DataGridViewTextBoxCell { Value = excessPipeCharge.OperationTimeFrame.Finish },
                new DataGridViewTextBoxCell { Value = excessPipeCharge.MaximumCount },
                new DataGridViewTextBoxCell { Value = excessPipeCharge.ChargePerCubicMeter },
                new DataGridViewTextBoxCell { Value = excessPipeCharge.Amount });

            dgvExcessPipeCharges.Rows.Add(row);
        }

        private void AddOtherCharge()
        {
            var otherCharge = new OtherCharge
            {
                Amount = nudOther_Amount.Value,
                Billing = null,
                Remarks = tbxOther_Remarks.Text,
                Type = (OtherChargeType)cmbxOther_OtherChargeType.SelectedItem,
                Unit = nudOther_Unit.Value
            };

            var row = new DataGridViewRow()
            {
                Height = 30
            };
            row.Cells.AddRange(
                new DataGridViewTextBoxCell { Value = otherCharge },
                new DataGridViewTextBoxCell { Value = otherCharge.Type },
                new DataGridViewTextBoxCell { Value = otherCharge.Amount },
                new DataGridViewTextBoxCell { Value = otherCharge.Unit },
                new DataGridViewTextBoxCell { Value = otherCharge.TotalAmount },
                new DataGridViewTextBoxCell { Value = otherCharge.Remarks });

            dgvOtherCharges.Rows.Add(row);
        }
        #endregion

        #region RemoveAll Entity
        private void RemoveAllPumpcreteCharges()
        {
            var header = "Pumpcrete Charges";
            var content = "Do you really want to remove all Pumpcrete Charges?";
            var result = MessageBox.Show(content, header, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dgvPumpcreteCharges.Rows.Clear();
            }
        }

        private void RemoveAllExcessPipeCharges()
        {
            var header = "Excess Pipe Charges";
            var content = "Do you really want to remove all Excess Pipe Charges?";
            var result = MessageBox.Show(content, header, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dgvExcessPipeCharges.Rows.Clear();
            }
        }

        private void RemoveAllOtherCharges()
        {
            var header = "Other Charges";
            var content = "Do you really want to remove all Other Charges?";
            var result = MessageBox.Show(content, header, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dgvOtherCharges.Rows.Clear();
            }
        }
        #endregion

        #region RemoveSelected Entity
        private void RemoveSelectedPumpcreteCharge()
        {
            var header = "Pumpcrete Charges";
            var content = "Do you really want to remove the selected Pumpcrete Charge?";
            var result = MessageBox.Show(content, header, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var row = dgvPumpcreteCharges.SelectedRows[0];
                dgvPumpcreteCharges.Rows.Remove(row);
            }
        }

        private void RemoveSelectedExcessPipeCharge()
        {
            var header = "Excess Pipe Charges";
            var content = "Do you really want to remove the selected Excess Pipe Charge?";
            var result = MessageBox.Show(content, header, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var row = dgvExcessPipeCharges.SelectedRows[0];
                dgvExcessPipeCharges.Rows.Remove(row);
            }
        }

        private void RemoveSelectedOtherCharge()
        {
            var header = "Other Charges";
            var content = "Do you really want to remove the selected Other Charge?";
            var result = MessageBox.Show(content, header, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var row = dgvOtherCharges.SelectedRows[0];
                dgvOtherCharges.Rows.Remove(row);
            }
        }
        #endregion

        #region EnableChargeRemoval
        private void EnablePumpcreteChargeRemoval()
        {
            var enable = dgvPumpcreteCharges.Rows.Count > 0;
            btnPumpcrete_RemoveAll.Enabled = enable;
            btnPumpcrete_RemoveSelected.Enabled = enable;
        }

        private void EnableExcessPipeChargesRemoval()
        {
            var enable = dgvExcessPipeCharges.Rows.Count > 0;
            btnExcessPipe_RemoveAll.Enabled = enable;
            btnExcessPipe_RemoveSelected.Enabled = enable;
        }

        private void EnableOtherChargeRemoval()
        {
            var enable = dgvOtherCharges.Rows.Count > 0;
            btnOther_RemoveAll.Enabled = enable;
            btnOther_RemoveSelected.Enabled = enable;
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSaveBilling_Click(object sender, EventArgs e)
        {
            if (ValidateBilling())
            {
                await SaveBillingAsync();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Include atleast 1 delivery.");
            }
        }

        private bool ValidateBilling()
        {
            foreach (DataGridViewRow row in dgvDeliveries.Rows)
            {
                if ((bool)row.Cells[colDelivery_Included.Name].Value)
                {
                    return true;
                }
            }

            //if (dgvPumpcreteCharges.Rows.Count > 0)
            //{
            //    return true;
            //}

            //if (dgvExcessPipeCharges.Rows.Count > 0)
            //{
            //    return true;
            //}

            //if (dgvOtherCharges.Rows.Count > 0)
            //{
            //    return true;
            //}

            return false;
        }

        private void ClearAll()
        {
            var deliveryRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvDeliveries.Rows)
            {
                if ((bool)row.Cells[colDelivery_Included.Name].Value)
                {
                    deliveryRows.Add(row);
                }
            }

            foreach (var item in deliveryRows)
            {
                dgvDeliveries.Rows.Remove(item);
            }
            cmbxStructureType.SelectedItem = BillingStructureTypeManager.DefaultValue;
            dtpBillingDate.Value = DateTime.Now;
            tbxSignatories_CertifiedBy.Text = string.Empty;
            tbxSignatories_CheckBy.Text = string.Empty;
            tbxSignatories_PreparedBy.Text = string.Empty;
            tbxSignatories_ReceivedBy.Text = string.Empty;
            dgvPumpcreteCharges.Rows.Clear();
            dgvExcessPipeCharges.Rows.Clear();
            dgvOtherCharges.Rows.Clear();
            ckbxIncludePumpCreteCharges.Checked = false;
            ckbxIncludeExcessPipeCharges.Checked = false;
            ckbxIncludeOtherCharges.Checked = false;
            tcBillingDefinition.SelectedTab = tpBilling_Deliveries;
        }

        private async Task SaveBillingAsync()
        {
            var billing = new Billing()
            {
                StructureType = (BillingStructureType)cmbxStructureType.SelectedItem,
                Project = (Project)dgvProjects.SelectedRows[0].Cells[colProject.Name].Value,
                BillingDate = dtpBillingDate.Value,
                PreparedBy = tbxSignatories_PreparedBy.Text,
                CheckedBy = tbxSignatories_CheckBy.Text,
                CertifiedBy = tbxSignatories_CertifiedBy.Text,
                ReceivedBy = tbxSignatories_ReceivedBy.Text,
                Notes = tbxNotes.Text
            };
            foreach (DataGridViewRow row in dgvDeliveries.Rows)
            {
                var included = (bool)row.Cells[colDelivery_Included.Name].Value;
                if (included)
                {
                    billing.Deliveries.Add((Citicon.Data.Delivery)row.Cells[colDelivery.Name].Value);
                }
            }

            foreach (DataGridViewRow row in dgvPumpcreteCharges.Rows)
            {
                billing.PumpcreteCharges.Add((PumpcreteCharge)row.Cells[colPumpcreteCharge.Name].Value);
            }

            foreach (DataGridViewRow row in dgvExcessPipeCharges.Rows)
            {
                billing.ExcessPipeCharges.Add((ExcessPipeCharge)row.Cells[colExcessPipeCharge.Name].Value);
            }

            foreach (DataGridViewRow row in dgvOtherCharges.Rows)
            {
                billing.OtherCharges.Add((OtherCharge)row.Cells[colOtherCharge.Name].Value);
            }

            try
            {
                billing = await BillingManager.InsertBillingAsync(billing);

                if (billing != null)
                {
                    BillingManager.Export(billing, OnExported, OnExportError);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void OnExportError(string message)
        {
            MessageBox.Show(message);
        }

        private void OnExported()
        {
            MessageBox.Show("Exported.");
        }

        private void DisplayInsertBillingResult(Task<Billing> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                MessageBox.Show($"The Billing No. is {task.Result.BillingNo}");
                //var reporting = new BillingReport(task.Result, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\Billings\{DateTime.Now.ToString("yyMMddhhmmss")}.docx", @"C:\\Users\user_2\Desktop\CITICON SYSTEMS FILE\citbil.dotx");
                //var exportTask = reporting.ExportAsync();
                //exportTask.ContinueWith(DisplayExportResult);
                MessageBox.Show("Exported!");
            }
            else
            {
                MessageBox.Show($"ERROR");
            }
        }

        private void DisplayExportResult(Task task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                MessageBox.Show("Exported!");
            }
        }
    }
}
