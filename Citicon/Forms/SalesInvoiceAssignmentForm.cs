using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class SalesInvoiceAssignmentForm : Form
    {
        public SalesInvoiceAssignmentForm()
        {
            InitializeComponent();
        }
        private void dgvBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalesInvoiceAssignmentForm_Load(object sender, EventArgs e)
        {
            LoadClientListWithoutBillingSiNumber();
        }

        private void LoadClientListWithoutBillingSiNumber()
        {
            dgvClients.Rows.Clear();
            var task = ClientManager.GetListWithoutBillingSiNumberAsync();
            task.ContinueWith(DisplayClientListWithoutBillingSiNumber);
        }

        private void DisplayClientListWithoutBillingSiNumber(Task<IEnumerable<Client>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    List<DataGridViewRow> rows = new List<DataGridViewRow>();
                    foreach (var item in task.Result)
                    {
                        var row = new DataGridViewRow();
                        row.Height = 30;
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Address });
                        rows.Add(row);
                    }
                    Invoke(new Action(() =>
                    {
                        dgvClients.Rows.AddRange(rows.ToArray());
                    }));
                }
            }
        }

        private void LoadBillingListWithoutSiNumberByProject(Project project)
        {
            dgvBilling.Rows.Clear();
            var task = BillingManager.GetListWithoutSiNumberByProjectAsync(project);
            task.ContinueWith(DisplayBillingListWithoutSiNumber);
        }

        private void DisplayBillingListWithoutSiNumber(Task<IEnumerable<Billing>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    List<DataGridViewRow> rows = new List<DataGridViewRow>();
                    foreach (var item in task.Result)
                    {
                        var row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewCheckBoxCell() { Value = false });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = item });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = item.Volume });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = item.AmountDue });
                        row.Height = 30;
                        rows.Add(row);
                    }
                    Invoke(new Action(() =>
                    {
                        dgvBilling.Rows.AddRange(rows.ToArray());
                    }));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSiNumber.Text))
            {
                MessageBox.Show("Invalid Sales Invoice No.");
                return;
            }

            var billings = new List<Billing>();
            foreach (DataGridViewRow row in dgvBilling.Rows)
            {
                var include = (bool)row.Cells[colBilling_Check.Name].Value;
                if (include)
                {
                    billings.Add((Billing)row.Cells[colBilling.Name].Value);
                }
            }
            var task = BillingManager.SaveSiNumberAsync(tbxSiNumber.Text, billings);
            if (task.Status == TaskStatus.RanToCompletion)
            {
                MessageBox.Show("Successfully saved!");
                Close();
            }
            else
            {
                MessageBox.Show("Failed to save.");
            }
        }

        private void dgvProjects_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProjects.SelectedRows.Count > 0)
            {
                var project = (Project)dgvProjects.SelectedRows[0].Cells[colProject.Name].Value;
                LoadBillingListWithoutSiNumberByProject(project);
            }
        }

        private void DisplayProjectListWithoutBillingSiNumberByClient(Task<IEnumerable<Project>> task)
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
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Location });
                        rows.Add(row);
                    }
                    Invoke(new Action(() =>
                    {
                        dgvProjects.Rows.AddRange(rows.ToArray());
                    }));
                }
            }
        }

        private void LoadProjectListWithoutBillingSiNumberByClient(Client client)
        {
            dgvProjects.Rows.Clear();
            var task = ProjectManager.GetListWithoutBillingSiNumberByClientAsync(client);
            task.ContinueWith(DisplayProjectListWithoutBillingSiNumberByClient);
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                var client = (Client)dgvClients.SelectedRows[0].Cells[colClient.Name].Value;
                LoadProjectListWithoutBillingSiNumberByClient(client);
            }
        }
    }
}
