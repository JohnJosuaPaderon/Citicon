using Citicon.Data;
using Citicon.DataManager;
using Citicon.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private async void SalesInvoiceAssignmentForm_Load(object sender, EventArgs e)
        {
            await LoadClientListWithoutBillingSiNumberAsync();
        }

        private async Task LoadClientListWithoutBillingSiNumberAsync()
        {
            dgvClients.Rows.Clear();
            var result = await ClientManager.GetListWithoutBillingSiNumberAsync();
            foreach (var item in result)
            {
                dgvClients.Rows.Add(new DataGridViewRow()
                    .SetHeight(30)
                    .AddTextBoxCell(item)
                    .AddTextBoxCell(item.Address));
            }
        }

        private async Task LoadBillingListWithoutSiNumberByProjectAsync(Project project)
        {
            dgvBilling.Rows.Clear();
            var result = await BillingManager.GetListWithoutSiNumberByProjectAsync(project);
            foreach (var item in result)
            {
                dgvBilling.Rows.Add(new DataGridViewRow()
                    .SetHeight(30)
                    .AddCheckBoxCell(false)
                    .AddTextBoxCell(item)
                    .AddTextBoxCell(item.Volume)
                    .AddTextBoxCell(item.AmountDue));
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

        private async void dgvProjects_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProjects.SelectedRows.Count > 0)
            {
                var project = (Project)dgvProjects.SelectedRows[0].Cells[colProject.Name].Value;
                await LoadBillingListWithoutSiNumberByProjectAsync(project);
            }
        }

        private void DisplayProjectListWithoutBillingSiNumberByClient(Task<IEnumerable<Project>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    
                }
            }
        }

        private async Task LoadProjectListWithoutBillingSiNumberByClientAsync(Client client)
        {
            dgvProjects.Rows.Clear();
            var result = await ProjectManager.GetListWithoutBillingSiNumberByClientAsync(client);
            foreach (var item in result)
            {
                dgvProjects.Rows.Add(new DataGridViewRow()
                    .SetHeight(30)
                    .AddTextBoxCell(item)
                    .AddTextBoxCell(item.Location));
            }
        }

        private async void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                var client = (Client)dgvClients.SelectedRows[0].Cells[colClient.Name].Value;
                await LoadProjectListWithoutBillingSiNumberByClientAsync(client);
            }
        }

        private async void dgvBilling_SelectionChanged(object sender, EventArgs e)
        {
            await GetDeliveriesAsync();
        }

        private async Task GetDeliveriesAsync()
        {
            DeliveriesDataGridView.Rows.Clear();

            if (dgvBilling.SelectedRows.Count == 1 && dgvBilling.SelectedRows[0].Cells[colBilling.Name].Value is Billing billing)
            {
                try
                {
                    var result = await DeliveryManager.GetListByBillingAsync(billing);

                    if (result != null && result.Any())
                    {
                        foreach (var delivery in result)
                        {
                            DeliveriesDataGridView.Rows.Add(new DataGridViewRow()
                                .SetHeight(30)
                                .AddTextBoxCell(delivery)
                                .AddTextBoxCell(delivery.DeliveryReceiptNumberDisplay)
                                .AddTextBoxCell(delivery.ProjectDesign)
                                .AddTextBoxCell(delivery.Volume));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
