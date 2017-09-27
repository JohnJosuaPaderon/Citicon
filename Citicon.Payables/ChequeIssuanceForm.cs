using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Payables
{
    public partial class ChequeIssuanceForm : Form
    {
        private PayableManager payableManager;
        private BankManager bankManager;
        private BankAccountManager bankAccountManager;
        private CompanyManager CompanyManager;
        private Supplier payee;
        private Payable[] payables;
        private Bank[] banks;
        private BankAccount[] bankAccounts;
        private string[] checkVoucherNumbers;
        private List<Bank> tempBanks;
        private List<BankAccount> tempBankAccounts;
        private decimal grandTotalAmount;

        string checkVoucherNumber;
        public ChequeIssuanceForm()
        {
            InitializeComponent();
            payableManager = new PayableManager();
            payableManager.ExceptionCatched += ExceptionCatched;
            //payableManager.NewChequeVoucherNumber += PayableManager_NewChequeVoucherNumber;
            payableManager.NewItemByChequeVoucherNumber += PayableManager_NewItemByChequeVoucherNumber;
            payableManager.Updated += PayableManager_Updated;

            bankManager = new BankManager();
            bankManager.ExceptionCatched += ExceptionCatched;
            bankManager.NewItemGenerated += BankManager_NewItemGenerated;

            bankAccountManager = new BankAccountManager();
            bankAccountManager.ExceptionCatched += ExceptionCatched;
            bankAccountManager.NewItemGenerated += BankAccountManager_NewItemGenerated;

            CompanyManager = new CompanyManager();
        }

        private void PayableManager_Updated(Payable e)
        {
            tbxCheckVoucherNumber.AutoCompleteCustomSource.Remove(e.ChequeVoucherNumber);

            //if (e.Description != ConfigurationManager.AppSettings["Payable.Description.InputTax"])
            //{
            //    grandTotalAmount += e.Debit;
            //}

            if (e.Expense == Expense.CashInBank)
            {
                grandTotalAmount += e.Value;
            }
        }

        private void BankAccountManager_NewItemGenerated(BankAccount e)
        {
            tempBankAccounts.Add(e);
        }

        private void BankManager_NewItemGenerated(Bank e)
        {
            if (e != null)
            {
                tempBanks.Add(e);
                Invoke(new Action(() => cmbxBanks.Items.Add(e)));
            }
        }

        private async Task LoadBanks()
        {
            tempBanks.Clear();
            banks = await bankManager.GetListAsync();
        }

        private async Task LoadBankAccounts()
        {
            tempBankAccounts.Clear();
            bankAccounts = await bankAccountManager.GetListAsync();
        }

        private void PayableManager_NewItemByChequeVoucherNumber(Payable e)
        {
            Invoke(new Action(() =>
            {
                if (payee == null) payee = e.Supplier;
                dgvPayables.Rows.Add(e, e.Company, e.Branch, e.Value.ToString("#,##0.00"));
            }));
        }

        private void PayableManager_NewChequeVoucherNumber(string e)
        {
            //Invoke(new Action(() => tbxCheckVoucherNumber.AutoCompleteCustomSource.Add(e)));
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private async void ChequeIssuanceForm_Load(object sender, EventArgs e)
        {
            tempBanks = new List<Bank>();
            tempBankAccounts = new List<BankAccount>();
            await LoadCheckVoucherNumbers();
            await LoadBanks();
            await LoadBankAccounts();
        }

        private async Task LoadCheckVoucherNumbers()
        {
            tbxCheckVoucherNumber.AutoCompleteCustomSource.Clear();
            checkVoucherNumbers = await payableManager.GetChequeVoucherNumberAsync(false);

            if (checkVoucherNumbers != null)
            {
                tbxCheckVoucherNumber.AutoCompleteCustomSource.AddRange(checkVoucherNumbers);
            }
        }

        private async Task LoadCompanies()
        {
            ChequeCompanyComboBox.Items.Clear();

            try
            {
                var companies = await CompanyManager.GetListAsync();

                if (companies != null && companies.Any())
                {
                    ChequeCompanyComboBox.Items.AddRange(companies);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task SetCheckVoucherNumber()
        {
            var x = tbxCheckVoucherNumber.Text.Trim();
            Color backColor = Color.White;
            Color foreColor = Color.Black;
            if (checkVoucherNumbers.Contains(x))
            {
                backColor = Color.FromArgb(50, 50, 50);
                foreColor = Color.FromArgb(255, 192, 192);
                if (x != checkVoucherNumber)
                {
                    payee = null;
                    checkVoucherNumber = x;
                    dgvPayables.Rows.Clear();
                    payables = await payableManager.GetListByChequeVoucherNumberAsync(x);
                    grandTotalAmount = 0;
                    foreach (DataGridViewRow row in dgvPayables.Rows)
                    {
                        var payable = (Payable)row.Cells[colPayable.Name].Value;
                        //if (payable.Description != ConfigurationManager.AppSettings["Payable.Description.InputTax"])
                        //{
                        //    grandTotalAmount += payable.Debit;
                        //}
                        if (payable.Expense == Expense.CashInBank)
                        {
                            grandTotalAmount += payable.Value;
                        }
                    }
                    tbxGrandTotal.Text = Math.Abs(grandTotalAmount).ToString("#,##0.00");
                    tbxPayee.Text = payee.Description;
                }
            }
            tbxCheckVoucherNumber.BackColor = backColor;
            tbxCheckVoucherNumber.ForeColor = foreColor;
            tbxPayee.BackColor = backColor;
            tbxPayee.ForeColor = foreColor;
        }

        private void ClearCheckVoucherNumber()
        {
            Color backColor = Color.White;
            Color foreColor = Color.Black;
            tbxCheckVoucherNumber.Text = string.Empty;
            tbxPayee.Text = string.Empty;
            tbxCheckVoucherNumber.BackColor = backColor;
            tbxCheckVoucherNumber.ForeColor = foreColor;
            tbxPayee.BackColor = backColor;
            tbxPayee.ForeColor = foreColor;
            payee = null;
            dgvPayables.Rows.Clear();
        }

        private void lblChangeCheckVoucherNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearCheckVoucherNumber();
        }

        private async void tbxCheckVoucherNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) await SetCheckVoucherNumber();
        }

        private void tbxCheckVoucherNumber_Leave(object sender, EventArgs e)
        {
            //await setCheckVoucherNumber();
        }

        private void cmbxBanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxBankAccounts.Items.Clear();
            cmbxBankAccounts.Items.AddRange(tempBankAccounts.Where(x => x.Bank == (Bank)cmbxBanks.SelectedItem)?.ToArray());
            tbxBank.Text = (cmbxBanks.SelectedItem as Bank)?.ToString();
        }

        private void tbxPayee_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbxBankAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bankAccount = (BankAccount)cmbxBankAccounts.SelectedItem;
            if (bankAccount.ChequeNumberEnd >= bankAccount.ChequeNumber)
            {
                tbxCheckNumber.Text = bankAccount.ChequeNumber.ToString("0000000");
            }
            else
            {
                tbxCheckNumber.Text = "0000000";
                MessageBox.Show("Insufficient cheque number!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tbxBankAccount.Text = bankAccount?.ToString();
        }

        private async void btnExportCheque_Click(object sender, EventArgs e)
        {
            if (cmbxBankAccounts.SelectedItem != null)
            {
                if (dgvPayables.Rows.Count > 0)
                {
                    grandTotalAmount = 0;
                    var rawChequeNumber = tbxCheckNumber.Text.Trim();
                    var chequeNumber = uint.Parse(rawChequeNumber);
                    var chequeCompany = ChequeCompanyComboBox.SelectedItem as Company;
                    if (chequeNumber <= 0)
                    {
                        MessageBox.Show("Insufficient cheque number!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (await payableManager.ChequeNumberExistsAsync(chequeNumber))
                    {
                        MessageBox.Show("Cheque No. already exists.");
                        return;
                    }
                    foreach (DataGridViewRow row in dgvPayables.Rows)
                    {
                        var payable = (Payable)row.Cells[colPayable.Name].Value;
                        payable.ChequeNumber = rawChequeNumber;
                        payable.ChequeDate = dtpChequeDate.Value;
                        payable.BankAccount = (BankAccount)cmbxBankAccounts.SelectedItem;
                        payable.TransactionDate = Supports.SystemDate;
                        payable.ChequeCompany = chequeCompany;
                        payableManager.Update(payable);
                    }
                    payableManager.ExportCheque(grandTotalAmount, payee, dtpChequeDate.Value);
                    var bankAccount = (BankAccount)cmbxBankAccounts.SelectedItem;
                    bankAccount.ChequeNumber++;
                    bankAccountManager.Update(bankAccount);
                    await LoadCheckVoucherNumbers();
                    dgvPayables.Rows.Clear();
                    tbxCheckNumber.Text = "0000000";
                    tbxCheckVoucherNumber.Text = string.Empty;
                    tbxPayee.Text = string.Empty;
                    ChequeCompanyComboBox.SelectedItem = null;
                    payee = null;
                    //cmbxBanks.SelectedItem = null;
                    //cmbxBankAccounts.Items.Clear();
                    tbxGrandTotal.Text = "0.00";
                    //await setCheckVoucherNumber();
                    ClearCheckVoucherNumber();
                    MessageBox.Show("Done!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("No Payables in the list!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please verify all details!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxCheckVoucherNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            var form = new ChequeNumberRangeForm(cmbxBankAccounts.SelectedItem as BankAccount);
            form.ShowDialog();

            var bankAccount = form.CurrentBankAccount;

            if (bankAccount != null)
            {
                cmbxBanks.SelectedItem = bankAccount.Bank;
                cmbxBankAccounts.SelectedItem = bankAccount;
                tbxCheckNumber.Text = bankAccount.ChequeNumber.ToString("0000000");
            }
        }
    }
}
