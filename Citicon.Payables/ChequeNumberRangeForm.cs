using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Payables
{
    public partial class ChequeNumberRangeForm : Form
    {
        public ChequeNumberRangeForm(BankAccount bankAccount)
        {
            InitializeComponent();
            BankManager = new BankManager();
            BankAccountManager = new BankAccountManager();
            BankAccountManager.Updated += BankAccountManager_Updated;
            BankAccountManager.UpdatedUnsuccessful += BankAccountManager_UpdatedUnsuccessful;
            CurrentBankAccount = bankAccount;
        }

        private void BankAccountManager_UpdatedUnsuccessful(BankAccount e)
        {
            if (e != null)
            {
                MessageBox.Show("Failed to update cheque no. range.");
            }

            CurrentBankAccount = e;
        }

        private void BankAccountManager_Updated(BankAccount e)
        {
            if (e != null)
            {
                MessageBox.Show("Cheque no. range has been updated.");
            }

            CurrentBankAccount = e;
        }

        private BankManager BankManager { get; }
        private BankAccountManager BankAccountManager { get; }

        public BankAccount CurrentBankAccount { get; private set; }

        private async Task GetBankListAsync()
        {
            cmbxBank.Items.Clear();

            try
            {
                var banks = await BankManager.GetListAsync();

                if (banks != null)
                {
                    cmbxBank.Items.AddRange(banks);
                }

                if (CurrentBankAccount != null)
                {
                    cmbxBank.SelectedItem = CurrentBankAccount.Bank;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetBankAccountListByBankAsync()
        {
            cmbxBankAccount.Items.Clear();

            try
            {
                var bankAccounts = await BankAccountManager.GetListByBankAsync(cmbxBank.SelectedItem as Bank);

                if (bankAccounts != null)
                {
                    cmbxBankAccount.Items.AddRange(bankAccounts.ToArray());
                }

                if (CurrentBankAccount != null)
                {
                    cmbxBankAccount.SelectedItem = CurrentBankAccount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task SaveBankAccountAsync()
        {
            var bankAccount = cmbxBankAccount.SelectedItem as BankAccount;

            if (bankAccount != null)
            {
                bankAccount.ChequeNumberStart = Convert.ToUInt32(nudRangeStart.Value);
                bankAccount.ChequeNumberEnd = Convert.ToUInt32(nudRangeEnd.Value);
                bankAccount.ChequeNumber = Convert.ToUInt32(nudRangeStart.Value);

                try
                {
                    await BankAccountManager.UpdateAsync(bankAccount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task<bool> ValidateChequeRangeAsync()
        {
            try
            {
                var validate = await BankAccountManager.ValidateChequeRangeAsync(cmbxBankAccount.SelectedItem as BankAccount, new UInt32Range { Start = Convert.ToUInt32(nudRangeStart.Value), End = Convert.ToUInt32(nudRangeEnd.Value) });

                if (!validate)
                {
                    MessageBox.Show("Invalid range.");
                }

                return validate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private async void ChequeNumberRangeForm_Load(object sender, EventArgs e)
        {
            await GetBankListAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void cmbxBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetBankAccountListByBankAsync();
        }

        private async void btnSaveRange_Click(object sender, EventArgs e)
        {
            if (await ValidateChequeRangeAsync())
            {
                await SaveBankAccountAsync();
            }
        }
    }
}
