using Citicon.Data;
using Citicon.DataManager;
using Citicon.Inventory.DataManager;
using Citicon.Payables.Data;
using Citicon.Payables.DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Payables
{
    public partial class MaintenanceForm : Form
    {
        private ExpenseManager expenseManager;
        private BankManager bankManager;
        private BankAccountManager bankAccountManager;
        private StockManager stockManager;

        private Expense activeExpense;
        private Bank activeBank;
        private BankAccount activeBankAccount;

        List<Expense> expenses;
        List<Bank> banks;
        List<BankAccount> bankAccounts;

        int idxExpense;
        int idxBank;
        int idxBankAccount;

        DataGridViewRow rowExpense;
        DataGridViewRow rowBank;
        DataGridViewRow rowBankAccount;

        public MaintenanceForm()
        {
            InitializeComponent();
            idxBank = -1;
            idxBankAccount = -1;
            idxExpense = -1;
            bankManager = new BankManager();
            bankManager.ExceptionCatched += ExceptionCatched;
            bankManager.NewItemGenerated += BankManager_NewItemGenerated;
            bankManager.Added += BankManager_Added;
            bankManager.AddedUnsuccessful += BankManager_AddedUnsuccessful;
            bankManager.Removed += BankManager_Removed;
            bankManager.RemovedUnsuccessful += BankManager_RemovedUnsuccessful;
            bankManager.Updated += BankManager_Updated;
            bankManager.UpdatedUnsuccessful += BankManager_UpdatedUnsuccessful;

            bankAccountManager = new BankAccountManager();
            bankAccountManager.ExceptionCatched += ExceptionCatched;
            bankAccountManager.NewItemGenerated += BankAccountManager_NewItemGenerated;
            bankAccountManager.Added += BankAccountManager_Added;
            bankAccountManager.AddedUnsuccessful += BankAccountManager_AddedUnsuccessful;
            bankAccountManager.Removed += BankAccountManager_Removed;
            bankAccountManager.RemovedUnsuccessful += BankAccountManager_RemovedUnsuccessful;
            bankAccountManager.Updated += BankAccountManager_Updated;
            bankAccountManager.UpdatedUnsuccessful += BankAccountManager_UpdatedUnsuccessful;

            expenseManager = new ExpenseManager();
            expenseManager.ExceptionCatched += ExceptionCatched;
            expenseManager.NewItemGenerated += ExpenseManager_NewItemGenerated;
            expenseManager.Added += ExpenseManager_Added;
            expenseManager.AddedUnsuccessful += ExpenseManager_AddedUnsuccessful;
            expenseManager.Removed += ExpenseManager_Removed;
            expenseManager.RemovedUnsuccessful += ExpenseManager_RemovedUnsuccessful;
            expenseManager.Updated += ExpenseManager_Updated;
            expenseManager.UpdatedUnsuccessful += ExpenseManager_UpdatedUnsuccessful;

            stockManager = new StockManager();
            stockManager.ExceptionCatched += ExceptionCatched;
            stockManager.NewUnpaidMrisNumberGenerated += StockManager_NewUnpaidMrisNumberGenerated;
        }

        private void StockManager_NewUnpaidMrisNumberGenerated(string e)
        {
            Invoke(new Action(() => tbxRevokeMrisNumber.AutoCompleteCustomSource.Add(e)));
        }

        #region DATA NEW ITEM GENERATED
        private void BankManager_NewItemGenerated(Bank e)
        {
            Invoke(new Action(() =>
            {
                dgvBanks.Rows.Add(e, e.Code);
                cmbxBankAccountbank.Items.Add(e);
            }));
        }
        private void BankAccountManager_NewItemGenerated(BankAccount e)
        {
            Invoke(new Action(() => dgvBankAccounts.Rows.Add(e, e.Bank, e.Code)));
        }
        private void ExpenseManager_NewItemGenerated(Expense e)
        {
            Invoke(new Action(() => dgvExpenses.Rows.Add(e, e.Code)));
        }
        #endregion

        #region DATA ADDED
        private async void BankManager_Added(Bank e)
        {
            notify("Successfully added!");
            await loadBanks();
            displayBank();
        }
        private async void BankAccountManager_Added(BankAccount e)
        {
            notify("Successfully added!");
            await loadBankAccounts();
            displayBankAccount();
        }
        private async void ExpenseManager_Added(Expense e)
        {
            notify("Successfully added!");
            await loadExpenses();
            displayExpense();
        }
        #endregion

        #region DATA ADDED UNSUCCESSFUL
        private void BankManager_AddedUnsuccessful(Bank e)
        {
            displayError("Adding failed!");
        }
        private void BankAccountManager_AddedUnsuccessful(BankAccount e)
        {
            displayError("Adding failed!");
        }
        private void ExpenseManager_AddedUnsuccessful(Expense e)
        {
            displayError("Adding failed!");
        }
        #endregion

        #region DATA REMOVED
        private void BankManager_Removed(Bank e)
        {
            notify("Successfully removed!");
            dgvBanks.Rows.Remove(rowBank);
            rowBank = null;
            idxBank = -1;
            activeBank = null;
        }
        private void BankAccountManager_Removed(BankAccount e)
        {
            notify("Successfully removed!");
            dgvBankAccounts.Rows.Remove(rowBankAccount);
            rowBankAccount = null;
            idxBankAccount = -1;
            activeBankAccount = null;
        }
        private void ExpenseManager_Removed(Expense e)
        {
            notify("Successfully removed!");
            dgvExpenses.Rows.Remove(rowExpense);
            rowExpense = null;
            idxExpense = -1;
            activeExpense = null;
        }
        #endregion

        #region DATA REMOVED UNSUCCESSFUL
        private void BankManager_RemovedUnsuccessful(Bank e)
        {
            displayError("Removing failed!");
        }
        private void BankAccountManager_RemovedUnsuccessful(BankAccount e)
        {
            displayError("Removing failed!");
        }
        private void ExpenseManager_RemovedUnsuccessful(Expense e)
        {
            displayError("Removing failed!");
        }
        #endregion

        #region DATA UPDATED
        private void BankManager_Updated(Bank e)
        {
            notify("Successfully updated!");
            insertActiveBank();
        }
        private void BankAccountManager_Updated(BankAccount e)
        {
            notify("Successfully updated!");
            insertActiveBankAccount();
        }
        private void ExpenseManager_Updated(Expense e)
        {
            notify("Successfully updated!");
            insertActiveExpense();
        }
        #endregion

        #region DATA UPDATED UNSUCCESSFUL
        private void BankManager_UpdatedUnsuccessful(Bank e)
        {
            displayError("Updating failed!");
        }
        private void BankAccountManager_UpdatedUnsuccessful(BankAccount e)
        {
            displayError("Updating failed!");
        }
        private void ExpenseManager_UpdatedUnsuccessful(Expense e)
        {
            displayError("Updating failed!");
        }
        #endregion

        #region LOAD DATA
        private async Task loadBanks()
        {
            dgvBanks.Rows.Clear();
            cmbxBankAccountbank.Items.Clear();
            activeBank = null;
            banks = (await bankManager.GetListAsync())?.ToList();
        }
        private async Task loadBankAccounts()
        {
            dgvBankAccounts.Rows.Clear();
            activeBankAccount = null;
            bankAccounts = (await bankAccountManager.GetListAsync())?.ToList();
        }
        private async Task loadExpenses()
        {
            dgvExpenses.Rows.Clear();
            activeExpense = null;
            expenses = (await expenseManager.GetListAsync())?.ToList();
        }
        #endregion
        
        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        #region DISPLAY MESSAGE
        private void notify(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void displayError(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private DialogResult ask(string message)
        {
            return MessageBox.Show(message, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #endregion

        #region DISPLAY DATA
        private void displayExpense()
        {
            tbxExpenseCode.Text = string.Empty;
            tbxExpenseDescription.Text = string.Empty;
            if (activeExpense != null)
            {
                tbxExpenseCode.Text = activeExpense.Code;
                tbxExpenseDescription.Text = activeExpense.Description;
            }
            else
            {
                tbxExpenseCode.Text = $"{Supports.CodePrefixes.Expense}-{generateCode(dgvExpenses, colExpenseCode)}";
            }
        }
        private void displayBank()
        {
            tbxBankCode.Text = string.Empty;
            tbxBankDescription.Text = string.Empty;
            if (activeBank != null)
            {
                tbxBankCode.Text = activeBank.Code;
                tbxBankDescription.Text = activeBank.Description;
            }
            else
            {
                tbxBankCode.Text = $"{Supports.CodePrefixes.Bank}-{generateCode(dgvBanks, colBankCode)}";
            }
        }
        private void displayBankAccount()
        {
            tbxBankAccountCode.Text = string.Empty;
            tbxBankAccountDescription.Text = string.Empty;
            cmbxBankAccountbank.SelectedItem = null;
            if (activeBankAccount != null)
            {
                tbxBankAccountCode.Text = activeBankAccount.Code;
                tbxBankAccountDescription.Text = activeBankAccount.Description;
                cmbxBankAccountbank.SelectedItem = activeBankAccount.Bank;
            }
        }
        #endregion

        #region DATA HAS CHANGES
        private bool bankHasChanges()
        {
            var code = tbxBankCode.Text.Trim();
            var description = tbxBankDescription.Text.Trim();
            if (activeBank != null)
            {
                if (activeBank.Code != code) return true;
                if (activeBank.Description != description) return true;
            }
            return false;
        }
        private bool bankAccountHasChanges()
        {
            var code = tbxBankAccountCode.Text.Trim();
            var description = tbxBankAccountDescription.Text.Trim();
            var bank = (Bank)cmbxBankAccountbank.SelectedItem;
            if (activeBankAccount != null)
            {
                if (activeBankAccount.Code != code) return true;
                if (activeBankAccount.Description != description) return true;
                if (activeBankAccount.Bank != bank) return true;
            }
            return false;
        }
        private bool expenseHasChanges()
        {
            var code = tbxExpenseCode.Text.Trim();
            var description = tbxExpenseDescription.Text.Trim();
            if (activeExpense != null)
            {
                if (activeExpense.Code != code) return true;
                if (activeExpense.Description != description) return true;
            }
            return false;
        }
        #endregion

        #region ENABLE DATA FIELDS
        private void enableBankFields(bool enabled)
        {
            tbxBankCode.Enabled = enabled;
            tbxBankDescription.Enabled = enabled;
        }
        private void enableBankAccountFields(bool enabled)
        {
            tbxBankAccountCode.Enabled = enabled;
            tbxBankAccountDescription.Enabled = enabled;
            cmbxBankAccountbank.Enabled = enabled;
        }
        private void enableExpenseFields(bool enabled)
        {
            tbxExpenseCode.Enabled = enabled;
            tbxExpenseDescription.Enabled = enabled;
        }
        #endregion

        #region INSERT ACTIVE DATA
        private void insertActiveBank()
        {
            if (idxBank < 0) idxBank = dgvBanks.Rows.Count - 1;
            dgvBanks.Rows.Insert(idxBank, activeBank, activeBank.Code);
            activeBank = null;
            rowBank = null;
            idxBank = -1;
            displayBank();
            enableBankFields(false);
        }
        private void insertActiveBankAccount()
        {
            if (idxBankAccount < 0) idxBankAccount = dgvBankAccounts.Rows.Count - 1;
            dgvBankAccounts.Rows.Insert(idxBankAccount, activeBankAccount, activeBankAccount.Bank, activeBankAccount.Code);
            activeBankAccount = null;
            rowBankAccount = null;
            idxBankAccount = -1;
            displayBankAccount();
            enableBankAccountFields(false);
        }
        private void insertActiveExpense()
        {
            if (idxExpense < 0) idxExpense = dgvExpenses.Rows.Count - 1;
            dgvExpenses.Rows.Insert(idxExpense, activeExpense, activeExpense.Code);
            activeExpense = null;
            rowExpense = null;
            idxExpense = -1;
            displayExpense();
            enableExpenseFields(false);
        }
        #endregion

        #region DATA VALIDATION
        private bool bankValidation()
        {
            var code = tbxBankCode.Text.Trim();
            var description = tbxBankDescription.Text.Trim();
            if (code == string.Empty)
            {
                displayError("Bank Code should be valid!"); return false;
            }
            if (description == string.Empty)
            {
                displayError("Bank Name should be valid!"); return false;
            }
            foreach (DataGridViewRow row in dgvBanks.Rows)
            {
                var bank = (Bank)row.Cells[colBank.Name].Value;
                if (code == bank.Code)
                {
                    displayError("Bank Code already in use!"); return false;
                }
                if (description == bank.Description)
                {
                    displayError("Bank Name already in use!"); return false;
                }
            }
            return true;
        }
        private bool bankAccountValidation()
        {
            var code = tbxBankAccountCode.Text.Trim();
            var description = tbxBankAccountDescription.Text.Trim();
            var bank = (Bank)cmbxBankAccountbank.SelectedItem;
            if (code == string.Empty) { displayError("Bank Account Code should be valid!"); return false; }
            if (description == string.Empty) { displayError("Bank Account Description should be valid!"); return false; }
            if (bank == null) { displayError("Bank should not be empty."); return false; }
            foreach (DataGridViewRow row in dgvBankAccounts.Rows)
            {
                var bankAccount = (BankAccount)row.Cells[colBankAccounts.Name].Value;
                if (bankAccount.Code == code) { displayError("Bank Account Code already in use!"); return false; }
                if (bankAccount.Description == description) { displayError("Bank Account Description already in use!"); return false; }
            }
            return true;
        }
        private bool expenseValidation()
        {
            var code = tbxExpenseCode.Text.Trim();
            var description = tbxExpenseDescription.Text.Trim();
            if (code == string.Empty)
            {
                displayError("Expense code must be valid!");
                return false;
            }
            if (description == string.Empty)
            {
                displayError("Expense name must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvExpenses.Rows)
            {
                var expense = (Expense)item.Cells[colExpenses.Name].Value;
                if (code == expense.Code)
                {
                    displayError("Expense Code already in use!");
                    return false;
                }
                if (description == expense.Description)
                {
                    displayError("Expense name already exists!");
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region SAVE DATA
        private void saveBank()
        {
            if (bankValidation())
            {
                var code = tbxBankCode.Text.Trim();
                var description = tbxBankDescription.Text.Trim();
                if (activeBank == null)
                {
                    activeBank = new Bank
                    {
                         Code = code,
                         Description = description
                    };
                    bankManager.Add(activeBank);
                }
                else
                {
                    if (bankHasChanges())
                    {
                        activeBank.Code = code;
                        activeBank.Description = description;
                        bankManager.Update(activeBank);
                    }
                    else displayError("No changes detected!");
                }
            }
        }
        private void saveBankAccount()
        {
            if (bankAccountValidation())
            {
                var code = tbxBankAccountCode.Text.Trim();
                var description = tbxBankAccountDescription.Text.Trim();
                var bank = (Bank)cmbxBankAccountbank.SelectedItem;
                if (activeBankAccount == null)
                {
                    activeBankAccount = new BankAccount
                    {
                        Bank = bank,
                        Code = code,
                        Description = description,
                        ChequeNumber = 1
                    };
                    bankAccountManager.Add(activeBankAccount);
                }
                else
                {
                    if (bankAccountHasChanges())
                    {
                        activeBankAccount.Code = code;
                        activeBankAccount.Bank = bank;
                        activeBankAccount.Description = description;
                        bankAccountManager.Update(activeBankAccount);
                    }
                    else displayError("No changes detected!");
                }
            }
        }
        private void saveExpense()
        {
            if (expenseValidation())
            {
                var code = tbxExpenseCode.Text.Trim();
                var description = tbxExpenseDescription.Text.Trim();
                if (activeExpense == null)
                {
                    activeExpense = new Expense
                    {
                        Code = code,
                        Description = description
                    };
                    expenseManager.Add(activeExpense);
                }
                else
                {
                    if (expenseHasChanges())
                    {
                        activeExpense.Code = code;
                        activeExpense.Description = description;
                        expenseManager.Update(activeExpense);
                    }
                    else displayError("No changes detected!");
                }
            }
        }
        #endregion

        #region CHECK DATA CHANGES
        private void checkBankChanges()
        {
            if (activeBank != null)
            {
                if (bankHasChanges())
                {
                    if (ask("Changes in bank details has been detected, do you want to save this first?") == DialogResult.Yes) saveBank();
                    else insertActiveBank();
                }
                else insertActiveBank();
            }
            displayBank();
            enableBankFields(false);
        }
        private void checkBankAccountChanges()
        {
            if (activeBankAccount != null)
            {
                if (bankAccountHasChanges())
                {
                    if (ask("Changes in bank account details has been detected, do you want to save this first?") == DialogResult.Yes) saveBankAccount();
                    else insertActiveBankAccount();
                }
                else insertActiveBankAccount();
            }
            displayBankAccount();
            enableBankAccountFields(false);
        }
        private void checkExpenseChanges()
        {
            if (activeExpense != null)
            {
                if (expenseHasChanges())
                {
                    if (ask("Changes in expense details has been detected, do you want to save this first?") == DialogResult.Yes)
                        saveExpense();
                    else insertActiveExpense();
                }
                else insertActiveExpense();
            }
            displayExpense();
            enableExpenseFields(false);
        }
        #endregion
        
        private async Task loadRevokableMrisNumber()
        {
            tbxRevokeMrisNumber.AutoCompleteCustomSource.Clear();
            await stockManager.GetUnpaidMrisNumberListAsync();
        }

        private bool exists(List<uint> list, uint x)
        {
            foreach (var item in list)
                if (x == item) return true;
            return false;
        }

        private string generateCode(DataGridView dgv, DataGridViewColumn col)
        {
            List<uint> rawCodes = new List<uint>();
            string code = string.Empty;
            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    code = (string)row.Cells[col.Name].Value;
                    rawCodes.Add(uint.Parse(code.Substring(code.Length - 4)));
                }
                for (int i = 1; i < 10000; i++)
                    if (!exists(rawCodes, (uint)i)) return i.ToString("0000");
            }
            return "0001";
        }

        private async void MaintenanceForm_Load(object sender, EventArgs e)
        {
            await loadBanks();
            await loadBankAccounts();
            await loadExpenses();
            await loadRevokableMrisNumber();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region DATA GRID VIEW DATA SELECTION CHANGED
        private void dgvBanks_SelectionChanged(object sender, EventArgs e)
        {
            enableBankFields(false);
        }
        private void dgvBankAccounts_SelectionChanged(object sender, EventArgs e)
        {
            enableBankAccountFields(false);
        }
        private void dgvExpenses_SelectionChanged(object sender, EventArgs e)
        {
            enableExpenseFields(false);
        }
        #endregion

        #region BUTTON NEW EXPENSE
        private void btnNewbank_Click(object sender, EventArgs e)
        {
            checkBankChanges();
            activeBank = null;
            displayBank();
            enableBankFields(true);
        }
        private void btnNewBankAccount_Click(object sender, EventArgs e)
        {
            checkBankAccountChanges();
            activeBankAccount = null;
            displayBankAccount();
            enableBankAccountFields(true);
        }
        private void btnNewExpense_Click(object sender, EventArgs e)
        {
            checkExpenseChanges();
            activeExpense = null;
            displayExpense();
            enableExpenseFields(true);
        }
        #endregion

        #region BUTTON EDIT EXPENSE
        private void btnEditBank_Click(object sender, EventArgs e)
        {
            if (dgvBanks.SelectedRows.Count == 1)
            {
                checkBankChanges();
                rowBank = dgvBanks.SelectedRows[0];
                idxBank = rowBank.Index;
                activeBank = (Bank)rowBank.Cells[colBank.Name].Value;
                displayBank();
                dgvBanks.Rows.Remove(rowBank);
                enableBankFields(true);
            }
        }
        private void btnEditBankAccount_Click(object sender, EventArgs e)
        {
            if (dgvBankAccounts.SelectedRows.Count == 1)
            {
                checkBankAccountChanges();
                rowBankAccount = dgvBankAccounts.SelectedRows[0];
                idxBankAccount = rowBankAccount.Index;
                activeBankAccount = (BankAccount)rowBankAccount.Cells[colBankAccounts.Name].Value;
                displayBankAccount();
                dgvBankAccounts.Rows.Remove(rowBankAccount);
                enableBankAccountFields(true);
            }
        }
        private void btnEditExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 1)
            {
                checkExpenseChanges();
                rowExpense = dgvExpenses.SelectedRows[0];
                idxExpense = rowExpense.Index;
                activeExpense = (Expense)rowExpense.Cells[colExpenses.Name].Value;
                displayExpense();
                dgvExpenses.Rows.Remove(rowExpense);
                enableExpenseFields(true);
            }
        }
        #endregion

        #region BUTTON REMOVE DATA
        private void btnRemoveBank_Click(object sender, EventArgs e)
        {
            if (dgvBanks.SelectedRows.Count == 1)
            {
                checkBankChanges();
                rowBank = dgvBanks.SelectedRows[0];
                idxBank = rowBank.Index;
                activeBank = (Bank)rowBank.Cells[colBank.Name].Value;
                if (ask($"Are you sure, you want to remove {activeBank}?") == DialogResult.Yes)
                {
                    bankManager.Remove(activeBank);
                }
                activeBank = null;
            }
        }
        private void btnRemoveBankAccount_Click(object sender, EventArgs e)
        {
            if (dgvBankAccounts.SelectedRows.Count == 1)
            {
                checkBankAccountChanges();
                rowBankAccount = dgvBankAccounts.SelectedRows[0];
                idxBankAccount = rowBankAccount.Index;
                activeBankAccount = (BankAccount)rowBankAccount.Cells[colBankAccounts.Name].Value;
                if (ask($"Are you sure, you want to remove {activeBankAccount}?") == DialogResult.Yes)
                {
                    bankAccountManager.Remove(activeBankAccount);
                }
                activeBankAccount = null;
            }
        }
        private void btnRemoveExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 1)
            {
                checkExpenseChanges();
                rowExpense = dgvExpenses.SelectedRows[0];
                idxExpense = rowExpense.Index;
                activeExpense = (Expense)rowExpense.Cells[colExpenses.Name].Value;
                if (ask($"Are you sure, you want to remove {activeExpense}?") == DialogResult.Yes)
                {
                    expenseManager.Remove(activeExpense);
                }
                activeExpense = null;
            }
        }
        #endregion

        #region BUTTON SAVE DATA
        private void btnSaveBank_Click(object sender, EventArgs e)
        {
            saveBank();
        }
        private void btnSaveBankAccount_Click(object sender, EventArgs e)
        {
            saveBankAccount();
        }
        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            saveExpense();
        }
        #endregion

        #region BUTTON CANCEL DATA
        private void btnCancelBank_Click(object sender, EventArgs e)
        {
            checkBankChanges();
        }
        private void btnCancelBankAccount_Click(object sender, EventArgs e)
        {
            checkBankAccountChanges();
        }
        private void btnCancelExpense_Click(object sender, EventArgs e)
        {
            checkExpenseChanges();
        }
        #endregion
        
        private string generateBankAccountCode()
        {
            List<uint> rawCodes = new List<uint>();
            string code = string.Empty;
            var tempBank = (Bank)cmbxBankAccountbank.SelectedItem;
            if (dgvBankAccounts.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dgvBankAccounts.Rows)
                {
                    var bank = (Bank)item.Cells[colBankAccountBank.Name].Value;
                    if (bank == tempBank)
                    {
                        code = (string)item.Cells[colBankAccountCode.Name].Value;
                        rawCodes.Add(uint.Parse(code.Substring(code.Length - 4)));
                    }
                }
                for (int i = 1; i < 10000; i++)
                    if (!exists(rawCodes, (uint)i)) return i.ToString("0000");
            }
            return "0001";
        }

        private void cmbxBankAccountbank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxBankAccountbank.SelectedItem != null)
            {
                var bank = (Bank)cmbxBankAccountbank.SelectedItem;
                tbxBankAccountCode.Text = $"{bank.Code}-{Supports.CodePrefixes.BankAccount}-{generateBankAccountCode()}";
            }
        }

        private async void btnRevokeMrisNumber_Click(object sender, EventArgs e)
        {
            if (await stockManager.RevokeMrisNumberAsync(tbxRevokeMrisNumber.Text.Trim()))
            {
                notify("MRIS No. has been revoked successfully!");
                tbxRevokeMrisNumber.Text = string.Empty;
                await loadRevokableMrisNumber();
            }
            else displayError("Failed to revoke MRIS No.");
        }
    }
}
