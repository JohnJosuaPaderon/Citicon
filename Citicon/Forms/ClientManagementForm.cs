using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.Dialogs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class ClientManagementForm : Form
    {
        public ClientManagementForm()
        {
            InitializeComponent();
        }

        private IEnumerable<Client> Clients { get; set; }

        private async void ClientManagementForm_Load(object sender, EventArgs e)
        {
            await GetClientListAsync();
        }

        private async Task GetClientListAsync()
        {
            ClientDataGridView.Rows.Clear();
            Clients = await ClientManager.GetListAsync();
            Search();
        }

        private void AddClientToUI(Client client)
        {
            if (client != null)
            {
                var row = new DataGridViewRow
                {
                    Height = 30
                };

                row.Cells.Add(new DataGridViewTextBoxCell { Value = client });
                ClientDataGridView.Rows.Add(row);
            }
        }

        private async Task GetClientAsync()
        {
            if (ClientDataGridView.SelectedRows.Count == 1)
            {
                var client = (Client)ClientDataGridView.SelectedRows[0].Cells[colClient.Name].Value;

                if (client != null)
                {
                    ClientView.Client = await ClientManager.GetByIdAsync(client.Id);
                }
            }
        }
        private async void ClientDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await GetClientAsync();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            SearchTextBox.ReadOnly = true;

            var key = SearchTextBox.Text.Trim().ToLower();
            ClientDataGridView.Rows.Clear();

            if (!string.IsNullOrWhiteSpace(key))
            {
                foreach (var client in Clients)
                {
                    if (client.CompanyName.ToLower().Contains(key))
                    {
                        AddClientToUI(client);
                    }
                }
            }
            else
            {
                foreach (var client in Clients)
                {
                    AddClientToUI(client);
                }
            }

            SearchTextBox.ReadOnly = false;
        }

        private async void AddNewButton_Click(object sender, EventArgs e)
        {
            var dialog = new AddEditClientDialog();
            dialog.ShowDialog();
            await GetClientListAsync();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (ClientView.Client != null)
            {
                var dialog = new AddEditClientDialog(ClientView.Client);
                dialog.ShowDialog();
                await GetClientListAsync();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var client = ClientView.Client;

            if (client != null)
            {
                var result = MessageBox.Show("Do you really want to delete the selected client?", "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        client = await ClientManager.DeleteAsync(client);

                        if (client != null)
                        {
                            for (int i = 0; i < ClientDataGridView.Rows.Count; i++)
                            {
                                var tempClient = ClientDataGridView.Rows[i].Cells[colClient.Name].Value as Client;

                                if (tempClient == client)
                                {
                                    ClientDataGridView.Rows.RemoveAt(i);
                                    break;
                                }
                            }

                            MessageBox.Show("Client has been deleted successfully.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ViewProjectsButton_Click(object sender, EventArgs e)
        {
            if (ClientView.Client != null)
            {
                var form = new ProjectManagementForm(ClientView.Client);
                form.ShowDialog();
            }
        }
    }
}
