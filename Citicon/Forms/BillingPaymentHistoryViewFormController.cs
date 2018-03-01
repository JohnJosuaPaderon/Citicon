using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.DataLinks;
using Citicon.WindowsForm;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    internal sealed class BillingPaymentHistoryViewFormController : FormControllerBase<BillingPaymentHistoryViewForm>
    {
        public BillingPaymentHistoryViewFormController(BillingPaymentHistoryViewForm form) : base(form)
        {
            _Clients = new DataGridViewItemSource<Client>(_Form.ClientsDataGridView, AddRow, SelectedItemChanged, _Form.LinkClientColumn, RefreshRow);
            _Billings = new DataGridViewItemSource<Billing>(_Form.BillingsDataGridView, AddRow, SelectedItemChanged, _Form.LinkBillingColumn, RefreshRow);
            _PaymentHistory = new DataGridViewItemSource<BillingPaymentHistory>(_Form.BillingPaymentHistoryDataGridView, AddRow, SelectedItemChanged, _Form.LinkBillingPaymentHistoryColumn, RefreshRow);
        }

        private readonly DataGridViewItemSource<Client> _Clients;
        private readonly DataGridViewItemSource<Billing> _Billings;
        private readonly DataGridViewItemSource<BillingPaymentHistory> _PaymentHistory;

        public async Task SearchClientAsync()
        {
            _Clients.Clear();

            var searchKey = _Form.SearchTextBox.Text;

            if (!string.IsNullOrWhiteSpace(searchKey))
            {
                try
                {
                    var clients = await ClientManager.SearchAsync(searchKey);

                    if (clients != null && clients.Any())
                    {
                        _Clients.AddRange(clients);
                    }
                }
                catch (Exception ex)
                {
                    _MessageDisplay.Exception(ex);
                }
            }
        }

        private async Task GetBillingsAsync(Client client)
        {
            _Billings.Clear();

            if (client != null)
            {
                try
                {
                    var billings = await BillingManager.GetListByClientAsync(client);

                    if (billings != null && billings.Any())
                    {
                        _Billings.AddRange(billings);
                    }
                }
                catch (Exception ex)
                {
                    _MessageDisplay.Exception(ex);
                }
            }
        }

        private async Task GetHistoryAsync(Billing billing)
        {
            _PaymentHistory.Clear();

            if (billing != null)
            {
                try
                {
                    var history = await BillingManager.GetPaymentHistoryAsync(billing);

                    if (history != null && history.Any())
                    {
                        _PaymentHistory.AddRange(history);
                    }
                }
                catch (Exception ex)
                {
                    _MessageDisplay.Exception(ex);
                }
            }
        }

        private DataGridViewRow AddRow(Client client)
        {
            return new DataGridViewRow()
                .SetHeight(30)
                .AddTextBoxCell(client);
        }

        private DataGridViewRow AddRow(Billing billing)
        {
            return new DataGridViewRow()
                .SetHeight(30)
                .AddTextBoxCell(billing)
                .AddTextBoxCell(billing.SiNumber)
                .AddTextBoxCell(billing.AmountDue)
                .AddTextBoxCell(billing.AmountPaid);
        }

        private DataGridViewRow AddRow(BillingPaymentHistory history)
        {
            return new DataGridViewRow()
                .SetHeight(30)
                .AddTextBoxCell(history)
                .AddTextBoxCell(history.PaymentDate)
                .AddTextBoxCell(history.AmountPaid)
                .AddTextBoxCell(history.Payment?.OrNumber)
                .AddTextBoxCell(history.Payment?.AckNumber)
                .AddTextBoxCell(history.Payment?.CrNumber)
                .AddTextBoxCell(history.Payment?.PrNumber)
                .AddTextBoxCell(history.Payment?.Bank)
                .AddTextBoxCell(history.Payment?.ChequeNumber)
                .AddTextBoxCell(history.Payment?.ChequeDate);
        }

        private async void SelectedItemChanged(Client client)
        {
            await GetBillingsAsync(client);
        }

        private async void SelectedItemChanged(Billing billing)
        {
            await GetHistoryAsync(billing);
        }

        private void SelectedItemChanged(BillingPaymentHistory history)
        {
            // TODO: Set form control vlaues if necessary
        }

        private void RefreshRow(DataGridViewRow row, Client client)
        {
            row.Cells[_Form.LinkClientColumn].Value = client;
        }

        private void RefreshRow(DataGridViewRow row, Billing billing)
        {
            row.Cells[_Form.LinkBillingColumn].Value = billing;
            row.Cells[_Form.LinkBillingSiNumberColumn].Value = billing.SiNumber;
            row.Cells[_Form.LinkBillingAmountDueColumn].Value = billing.AmountDue;
            row.Cells[_Form.LinkBillingAmountPaidColumn].Value = billing.AmountPaid;
        }

        private void RefreshRow(DataGridViewRow row, BillingPaymentHistory history)
        {
            row.Cells[_Form.LinkBillingPaymentHistoryColumn].Value = history;
            row.Cells[_Form.LinkBillingPaymentHistoryPaymentDateColumn].Value = history.PaymentDate;
            row.Cells[_Form.LinkBillingPaymentHistoryAmountPaidColumn].Value = history.AmountPaid;
            row.Cells[_Form.LinkBillingPaymentHistoryOrNumberColumn].Value = history.Payment?.OrNumber;
            row.Cells[_Form.LinkBillingPaymentHistoryAckNumberColumn].Value = history.Payment?.AckNumber;
            row.Cells[_Form.LinkBillingPaymentHistoryCrNumberColumn].Value = history.Payment?.CrNumber;
            row.Cells[_Form.LinkBillingPaymentHistoryPrNumberColumn].Value = history.Payment?.PrNumber;
            row.Cells[_Form.LinkBillingPaymentHistoryBankColumn].Value = history.Payment?.Bank;
            row.Cells[_Form.LinkBillingPaymentHistoryChequeNumberColumn].Value = history.Payment?.ChequeNumber;
            row.Cells[_Form.LinkBillingPaymentHistoryChequeDateColumn].Value = history.Payment?.ChequeDate;
        }
    }
}
