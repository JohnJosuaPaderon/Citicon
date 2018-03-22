using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.DataLinks;
using Citicon.WindowsForm;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    internal sealed class ClientAdvancePaymentManagementFormController : FormControllerBase<ClientAdvancePaymentManagementForm>
    {
        public ClientAdvancePaymentManagementFormController(ClientAdvancePaymentManagementForm form) : base(form)
        {
            _Clients = new DataGridViewItemSource<Client>(_Form.ClientsDataGridView, AddRow, SelectedItemChanged, "ClientColumn", RefreshRow);
            _AdvancePayments = new DataGridViewItemSource<ClientAdvancePayment>(_Form.ClientAdvancePaymentsDataGridView, AddRow, SelectedItemChanged, "ClientAdvancePaymentColumn", RefreshRow);
        }

        private readonly DataGridViewItemSource<Client> _Clients;
        private readonly DataGridViewItemSource<ClientAdvancePayment> _AdvancePayments;

        public async Task SearchAsync()
        {
            _Clients.Clear();

            var searchKey = _Form.SearchTextBox.Text;

            if (!string.IsNullOrWhiteSpace(searchKey))
            {
                var result = await ClientManager.SearchAsync(searchKey);

                if (result != null && result.Any())
                {
                    _Clients.AddRange(result);
                }
            }
        }

        private void RefreshRow(DataGridViewRow row, Client client)
        {
            row.Cells["ClientColumn"].Value = client;
            row.Cells["Client_CreditColumn"].Value = client.Credit;
        }
        
        private void RefreshRow(DataGridViewRow row, ClientAdvancePayment advancePayment)
        {
            row.Cells["ClientAdvancePaymentColumn"].Value = advancePayment;
            row.Cells["ClientAdvancePayment_TransactionDateColumn"].Value = advancePayment.TransactionDate;
            row.Cells["ClientAdvancePayment_AddedValueColumn"].Value = advancePayment.AddedValue;
        }

        private async void SelectedItemChanged(Client client)
        {
            _Form.CompanyNameTextBox.Text = string.Empty;
            _Form.AddressTextBox.Text = string.Empty;

            if (client != null)
            {
                _Form.CompanyNameTextBox.Text = client.CompanyName;
                _Form.AddressTextBox.Text = client.Address;
            }

            await GetAdvancePaymentsAsync(client);
        }

        private void SelectedItemChanged(ClientAdvancePayment advancePayment)
        {
            
        }

        private async Task GetAdvancePaymentsAsync(Client client)
        {
            _AdvancePayments.Clear();

            if (client != null)
            {
                var result = await ClientManager.GetAdvancePaymentsAsync(client);

                if (result != null && result.Any())
                {
                    _AdvancePayments.AddRange(result);
                }
            }
        }

        private DataGridViewRow AddRow(Client client)
        {
            return new DataGridViewRow()
                .SetHeight(30)
                .AddTextBoxCell(client)
                .AddTextBoxCell(client.Credit);
        }

        private DataGridViewRow AddRow(ClientAdvancePayment advancePayment)
        {
            return new DataGridViewRow()
                .SetHeight(30)
                .AddTextBoxCell(advancePayment)
                .AddTextBoxCell(advancePayment.TransactionDate)
                .AddTextBoxCell(advancePayment.AddedValue);
        }

        public async Task AddAsync()
        {
            var selected = _Clients.SelectedItem;

            if (selected != null)
            {
                var result = AddEditClientAdvancePaymentForm.Add(selected);

                if (result != null)
                {
                    await GetAdvancePaymentsAsync(result.Client);
                    selected.Credit = await ClientManager.GetCreditAsync(result.Client);
                    _Clients.RefreshSelected();
                }
            }
        }
    }
}
