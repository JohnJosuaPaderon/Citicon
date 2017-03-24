using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.Dialogs;
using System;
using System.Linq;
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

        private async void ClientManagementForm_Load(object sender, EventArgs e)
        {
            await GetClientListAsync();
        }

        private async Task GetClientListAsync()
        {
            var clients = await ClientManager.GetListAsync();

            if (clients != null && clients.Any())
            {
                foreach (var client in clients)
                {
                    AddClientToUI(client);
                }
            }
        }

        private void AddClientToUI(Client client)
        {
            if (client != null)
            {
                var row = new DataGridViewRow();
                row.Height = 30;

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
            var key = SearchTextBox.Text.Trim().ToUpper();

            if (!string.IsNullOrWhiteSpace(key))
            {
                foreach (DataGridViewRow row in ClientDataGridView.Rows)
                {
                    if (row.Cells[colClient.Name].Value is Client client && client.CompanyName.ToUpper().StartsWith(key))
                    {
                        row.Selected = true;
                        ClientDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            var dialog = new AddEditClientDialog();
            dialog.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ClientView.Client != null)
            {
                var dialog = new AddEditClientDialog(ClientView.Client);
                dialog.ShowDialog();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewProjectsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
