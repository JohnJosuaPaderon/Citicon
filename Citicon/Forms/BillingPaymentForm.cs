using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class BillingPaymentForm : Form
    {
        public BillingPaymentForm()
        {
            InitializeComponent();
        }

        private void BillingPaymentForm_Load(object sender, EventArgs e)
        {
            LoadClientsWithBillingSiNumber();
        }

        private void LoadClientsWithBillingSiNumber()
        {
            var task = ClientManager.GetListWithUnpaidBillingSiNumberAsync();
            task.ContinueWith(DisplayGetListWithUnpaidBillingSiNumberResult);
        }

        private void DisplayGetListWithUnpaidBillingSiNumberResult(Task<IEnumerable<Client>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    Invoke(new Action(() =>
                    {
                        cmbxClients.Items.Clear();
                        cmbxClients.Items.AddRange(task.Result.ToArray());
                    }));
                }
            }
        }

        private void LoadProjectListWithUnpaidBillingSiNumberByClient(Client client)
        {
            var task = ProjectManager.GetListWithUnpaidBillingSiNumberByClientAsync(client);
            task.ContinueWith(DisplayGetProjectListWithUnpaidBillingSiNumberByClientResult);
        }

        private void DisplayGetProjectListWithUnpaidBillingSiNumberByClientResult(Task<IEnumerable<Project>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    Invoke(new Action(() =>
                    {
                        cmbxProjects.Items.Clear();
                        cmbxProjects.Items.AddRange(task.Result.ToArray());
                    }));
                }
            }
        }

        private void cmbxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxClient_Address.Text = string.Empty;
            ClearProjectDetails();
            if (cmbxClients.SelectedItem != null)
            {
                var client = (Client)cmbxClients.SelectedItem;
                tbxClient_Address.Text = client.Address;
                LoadProjectListWithUnpaidBillingSiNumberByClient(client);
            }
        }

        private void ClearProjectDetails()
        {
            tbxProject_Location.Text = string.Empty;
            dgvSalesInvoices.Rows.Clear();
            dgvBillings.Rows.Clear();
            ClearBillingInfo();
        }

        private void cmbxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearProjectDetails();
            if (cmbxProjects.SelectedItem != null)
            {
                var project = (Project)cmbxProjects.SelectedItem;
                tbxProject_Location.Text = project.Location;
                LoadUnpaidSalesInvoiceListByProject(project);
                LoadProjectBillingInfo(project);
            }
        }

        private void ClearBillingInfo()
        {
            nudRunningBalance.Value = 0;
            nudTotalAmountPaid.Value = 0;
            nudTotalAmountToBePaid.Value = 0;
        }

        private void LoadProjectBillingInfo(Project project)
        {
            var task = ProjectManager.GetBillingInfoAsync(project);
            task.ContinueWith(DisplayGetProjectBillingInfoResult);
        }

        private void DisplayGetProjectBillingInfoResult(Task<ProjectBillingInfo> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    Invoke(new Action(() =>
                    {
                        nudRunningBalance.Value = task.Result.RunningBalance;
                        nudTotalAmountPaid.Value = task.Result.TotalAmountPaid;
                    }));
                }
            }
        }

        private void LoadUnpaidSalesInvoiceListByProject(Project project)
        {
            var task = SalesInvoiceManager.GetUnpaidListByProject(project);
            task.ContinueWith(DisplayUnpaidSalesInvoiceListByProjectResult);
        }

        private void DisplayUnpaidSalesInvoiceListByProjectResult(Task<IEnumerable<SalesInvoice>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                Invoke(new Action(() =>
                {
                    dgvSalesInvoices.Rows.Clear();
                }));

                if (task.Result != null)
                {
                    var rows = new List<DataGridViewRow>();
                    foreach (var item in task.Result)
                    {
                        var row = new DataGridViewRow();
                        row.Height = 30;
                        row.Cells.Add(new DataGridViewCheckBoxCell { Value = false });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.TotalAmountDue });
                        rows.Add(row);
                    }

                    Invoke(new Action(() =>
                    {
                        dgvSalesInvoices.Rows.AddRange(rows.ToArray());
                    }));
                }
            }
        }

        private void dgvSalesInvoices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var salesInvoice = (SalesInvoice)dgvSalesInvoices.Rows[e.RowIndex].Cells[colSiNumber.Name].Value;
                var include = (bool)dgvSalesInvoices.Rows[e.RowIndex].Cells[colSiNumber_Include.Name].Value;

                if (include)
                {
                    AppendBillingBySalesInvoice(salesInvoice);
                }
                else
                {
                    ExcludeBillingBySalesInvoice(salesInvoice);
                }
            }
        }

        private void ExcludeBillingBySalesInvoice(SalesInvoice salesInvoice)
        {
            var rows = new List<DataGridViewRow>();
            for (int i = 0; i < dgvBillings.Rows.Count; i++)
            {
                var billing = (Billing)dgvBillings.Rows[i].Cells[colBilling.Name].Value;
                if (billing.SiNumber == salesInvoice.Number)
                {
                    rows.Add(dgvBillings.Rows[i]);
                }
            }
            foreach (var row in rows)
            {
                dgvBillings.Rows.Remove(row);
            }
        }

        private void AppendBillingBySalesInvoice(SalesInvoice salesInvoice)
        {
            var task = BillingManager.GetUnpaidListBySalesInvoiceAsync(salesInvoice);
            task.ContinueWith(DisplayGetUnpaidListBySalesInvoiceResult);
        }

        private void DisplayGetUnpaidListBySalesInvoiceResult(Task<IEnumerable<Billing>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    var rows = new List<DataGridViewRow>();
                    foreach (var item in task.Result)
                    {
                        var row = new DataGridViewRow();
                        row.Height = 30;
                        row.Cells.Add(new DataGridViewCheckBoxCell { Value = false });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.SiNumber });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.AmountDue });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.AmountPaid });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.SubTotal });
                        rows.Add(row);
                    }
                    Invoke(new Action(() =>
                    {
                        dgvBillings.Rows.AddRange(rows.ToArray());
                    }));
                }
            }
        }

        private void dgvSalesInvoices_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSalesInvoices.IsCurrentCellDirty)
            {
                dgvSalesInvoices.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvBillings_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvBillings.IsCurrentCellDirty)
            {
                dgvBillings.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvBillings_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                var billing = (Billing)dgvBillings.Rows[e.RowIndex].Cells[colBilling.Name].Value;
                var included = (bool)dgvBillings.Rows[e.RowIndex].Cells[colBilling_Include.Name].Value;
                if (included)
                {
                    IncrementTotalAmountToBePaid(billing.SubTotal);
                }
                else
                {
                    DecrementTotalAmountToBePaid(billing.SubTotal);
                }
            }
        }

        private void DecrementTotalAmountToBePaid(decimal subTotal)
        {
            var amountToBePaid = nudTotalAmountToBePaid.Value;
            nudTotalAmountToBePaid.Value = amountToBePaid - subTotal;
        }

        private void IncrementTotalAmountToBePaid(decimal subTotal)
        {
            var amountToBePaid = nudTotalAmountToBePaid.Value;
            nudTotalAmountToBePaid.Value = amountToBePaid + subTotal;
        }

        private void nudTotalAmountToBePaid_ValueChanged(object sender, EventArgs e)
        {
            btnPayCheckedBillings.Enabled = nudTotalAmountToBePaid.Value > 0;
        }

        private void btnPayCheckedBillings_Click(object sender, EventArgs e)
        {
            List<Billing> billings = new List<Billing>();
            foreach (DataGridViewRow row in dgvBillings.Rows)
            {
                var included = (bool)row.Cells[colBilling_Include.Name].Value;
                if (included)
                {
                    var billing = (Billing)row.Cells[colBilling.Name].Value;
                    billings.Add(billing);
                }
            }
            var form = new BillingPaymentConfirmationForm(billings);
            form.ShowDialog();
            ReloadBillings();
        }

        private void ReloadBillings()
        {
            nudTotalAmountToBePaid.Value = 0;
            foreach (DataGridViewRow row in dgvSalesInvoices.Rows)
            {
                var included = (bool)row.Cells[colSiNumber_Include.Name].Value;
                if (included)
                {
                    dgvBillings.Rows.Clear();
                    var salesInvoice = (SalesInvoice)row.Cells[colSiNumber.Name].Value;
                    AppendBillingBySalesInvoice(salesInvoice);
                }
            }
        }

        private void dgvBillings_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            nudTotalAmountToBePaid.Value = 0;
        }
    }
}
