using Citicon.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class ClientSearchDialog : Form
    {
        public static Client Show(IEnumerable<Client> clients)
        {
            var dialog = new ClientSearchDialog(clients);
            dialog.ShowDialog();

            return dialog.SelectedClient;
        }

        private ClientSearchDialog(IEnumerable<Client> clients)
        {
            InitializeComponent();
            Clients = clients;
        }

        private void ClientSearchDialog_Load(object sender, EventArgs e)
        {
            LoadClientList();
        }

        private Client SelectedClient;
        private IEnumerable<Client> Clients { get; }

        private void LoadClientList()
        {
            try
            {
                foreach (var client in Clients)
                {
                    AddToUI(client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToUI(Client client)
        {
            var row = new DataGridViewRow()
            {
                Height = 30
            };
            row.Cells.Add(new DataGridViewTextBoxCell { Value = client });
            ClientDataGridView.Rows.Add(row);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var key = SearchTextBox.Text.Trim().ToUpper();

            foreach (DataGridViewRow row in ClientDataGridView.Rows)
            {
                if (row.Cells[colClient.Name].Value is Client client)
                {
                    if (client.CompanyName.Contains(key))
                    {
                        row.Selected = true;
                        ClientDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (ClientDataGridView.SelectedRows.Count == 1)
            {
                SelectedClient = ClientDataGridView.SelectedRows[0].Cells[colClient.Name].Value as Client;
                Close();
            }
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            SelectedClient = null;
            Close();
        }
    }
}
