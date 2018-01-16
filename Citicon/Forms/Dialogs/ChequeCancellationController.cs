using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Citicon.Forms.Dialogs
{
    internal sealed class ChequeCancellationController : FormControllerBase<ChequeCancellationDialog>
    {
        public ChequeCancellationController(ChequeCancellationDialog form) : base(form)
        {

        }

        public void ResetDetails()
        {
            _Form.BankComboBox.SelectedItem = null;
            _Form.ChequeNumberTextBox.Text = string.Empty;
            _Form.RemarksTextBox.Text = string.Empty;
            _Form.BankComboBox.Focus();
        }

        public void Initialize()
        {
            LoadBanks();
        }

        public async Task UpdateBankAccountsAsync()
        {
            await LoadBankAccountsAsync(_Form.BankComboBox.SelectedItem as Bank);
        }

        public async Task CancelChequeAsync()
        {
            if (Validate())
            {
                try
                {
                    var chequeNumber = _Form.ChequeNumberTextBox.Text.Trim();
                    var bankAccount = _Form.BankAccountComboBox.SelectedItem as BankAccount;
                    var remarks = _Form.RemarksTextBox.Text;

                    var exists = await ChequeManager.IsCancelledAsync(chequeNumber, bankAccount);

                    if (exists)
                    {
                        _MessageDisplay.Warning("Cheque is already cancelled.");
                    }
                    else
                    {
                        var result = await ChequeManager.CancelAsync(new VoidCheque
                        {
                            BankAccount = bankAccount,
                            ChequeNumber = chequeNumber,
                            Remarks = remarks
                        });

                        if (result != null)
                        {
                            _MessageDisplay.Inform("Cheque cancelled successfully.");
                            ResetDetails();
                        }
                        else
                        {
                            _MessageDisplay.Error("Failed to cancel cheque.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    _MessageDisplay.Exception(ex);
                }
            }
        }

        private bool Validate()
        {
            if (!(_Form.BankComboBox.SelectedItem is Bank))
            {
                _MessageDisplay.Warning("Invalid bank.");
            }
            else if (!(_Form.BankAccountComboBox.SelectedItem is BankAccount))
            {
                _MessageDisplay.Warning("Invalid bank account.");
            }
            else if (string.IsNullOrWhiteSpace(_Form.ChequeNumberTextBox.Text))
            {
                _MessageDisplay.Warning("Invalid cheque no.");
            }
            else
            {
                return true;
            }

            return false;
        }

        private void LoadBanks()
        {
            _Form.BankComboBox.Items.Clear();

            try
            {
                var result = BankManager.GetList();

                if (result != null && result.Any())
                {
                    _Form.BankComboBox.Items.AddRange(result);
                }
            }
            catch (Exception ex)
            {
                _MessageDisplay.Exception(ex);
            }
        }

        private async Task LoadBankAccountsAsync(Bank bank)
        {
            _Form.BankAccountComboBox.Items.Clear();

            if (bank != null)
            {
                try
                {
                    var result = await BankAccountManager.GetListByBankAsync(bank);

                    if (result != null && result.Any())
                    {
                        foreach (var bankAccount in result)
                        {
                            _Form.BankAccountComboBox.Items.Add(bankAccount);
                        }
                    }
                }
                catch (Exception ex)
                {
                    _MessageDisplay.Exception(ex);
                }
            }
        }
    }
}
