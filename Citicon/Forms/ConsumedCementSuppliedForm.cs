using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.Dialogs;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class ConsumedCementSuppliedForm : Form
    {
        public ConsumedCementSuppliedForm()
        {
            InitializeComponent();
        }

        private async Task GetClientListAsync()
        {
            ClientDataGridView.Rows.Clear();

            try
            {
                var clients = await ClientManager.GetListWithCementSuppliedProjectAsync();

                if (clients != null && clients.Any())
                {
                    foreach (var client in clients)
                    {
                        AddToUi(client);
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
                    var projects = await ProjectManager.GetCementSuppliedListByClientAsync(client);

                    if (projects != null && projects.Any())
                    {
                        foreach (var project in projects)
                        {
                            AddToUi(project);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task GetDeliveryListAsync()
        {
            DeliveryDataGridView.Rows.Clear();

            if (ProjectDataGridView.SelectedRows.Count == 1)
            {
                try
                {
                    var project = ProjectDataGridView.SelectedRows[0].Cells[ProjectColumn.Name].Value as Project;
                    var deliveries = await DeliveryManager.GetListByProjectAsync(project);

                    if (deliveries != null && deliveries.Any())
                    {
                        foreach (var delivery in deliveries)
                        {
                            AddToUi(delivery);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddToUi(Client client)
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

        private void AddToUi(Project project)
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

        private void AddToUi(Delivery delivery)
        {
            if (delivery != null)
            {
                var row = new DataGridViewRow
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.ProjectDesign });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.DeliveryDate });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.Volume });
                DeliveryDataGridView.Rows.Add(row);
            }
        }

        private void ManageDelivery()
        {
            if (DeliveryDataGridView.SelectedRows.Count == 1)
            {
                var dialog = new ManageCementSuppliedDialog(DeliveryDataGridView.SelectedRows[0].Cells[DeliveryColumn.Name].Value as Delivery);
                dialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("No delivery selected.");
            }
        }

        private async void ConsumedCementSuppliedForm_Load(object sender, EventArgs e)
        {
            await GetClientListAsync();
        }

        private async void ClientDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await GetProjectListAsync();
        }

        private async void ProjectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await GetDeliveryListAsync();
        }

        private void ManageSuppliedCementsButton_Click(object sender, EventArgs e)
        {
            ManageDelivery();
        }
    }
}
