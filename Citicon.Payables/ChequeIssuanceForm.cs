using Citicon.Data;
using Citicon.DataManager;
using Citicon.Payables.Data;
using Citicon.Payables.DataManager;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        }

        private void PayableManager_Updated(Payable e)
        {
            tbxCheckVoucherNumber.AutoCompleteCustomSource.Remove(e.ChequeVoucherNumber);

            if (e.Description != ConfigurationManager.AppSettings["Payable.Description.InputTax"])
            {
                grandTotalAmount += e.Debit;
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

        private async Task loadBanks()
        {
            tempBanks.Clear();
            banks = await bankManager.GetListAsync();
        }

        private async Task loadBankAccounts()
        {
            tempBankAccounts.Clear();
            bankAccounts = await bankAccountManager.GetListAsync();
        }

        private void PayableManager_NewItemByChequeVoucherNumber(Payable e)
        {
            Invoke(new Action(() =>
            {
                if (payee == null) payee = e.Supplier;
                dgvPayables.Rows.Add(e, e.Company, e.Branch, e.Debit.ToString("#,##0.00"));
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
            await loadCheckVoucherNumbers();
            await loadBanks();
            await loadBankAccounts();
        }

        private async Task loadCheckVoucherNumbers()
        {
            tbxCheckVoucherNumber.AutoCompleteCustomSource.Clear();
            checkVoucherNumbers = await payableManager.GetChequeVoucherNumberAsync(false);

            if (checkVoucherNumbers != null)
            {
                tbxCheckVoucherNumber.AutoCompleteCustomSource.AddRange(checkVoucherNumbers);
            }
        }

        private async Task setCheckVoucherNumber()
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
                        if (payable.Description != ConfigurationManager.AppSettings["Payable.Description.InputTax"])
                        {
                            grandTotalAmount += payable.Debit;
                        }
                        tbxGrandTotal.Text = grandTotalAmount.ToString("#,##0.00");
                    }
                    tbxPayee.Text = payee.Description;
                }
            }
            tbxCheckVoucherNumber.BackColor = backColor;
            tbxCheckVoucherNumber.ForeColor = foreColor;
            tbxPayee.BackColor = backColor;
            tbxPayee.ForeColor = foreColor;
        }

        private void clearCheckVoucherNumber()
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
            clearCheckVoucherNumber();
        }

        private async void tbxCheckVoucherNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) await setCheckVoucherNumber();
        }

        private async void tbxCheckVoucherNumber_Leave(object sender, EventArgs e)
        {
            await setCheckVoucherNumber();
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
                    var chequeNumber = tbxCheckNumber.Text.Trim();
                    if (uint.Parse(chequeNumber) <= 0)
                    {
                        MessageBox.Show("Insufficient cheque number!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    foreach (DataGridViewRow row in dgvPayables.Rows)
                    {
                        var payable = (Payable)row.Cells[colPayable.Name].Value;
                        payable.ChequeNumber = chequeNumber;
                        payable.ChequeDate = dtpChequeDate.Value;
                        payable.BankAccount = (BankAccount)cmbxBankAccounts.SelectedItem;
                        payable.TransactionDate = Supports.SystemDate;
                        payableManager.Update(payable);
                    }
                    payableManager.ExportCheque(grandTotalAmount, payee, dtpChequeDate.Value);
                    var bankAccount = (BankAccount)cmbxBankAccounts.SelectedItem;
                    bankAccount.ChequeNumber++;
                    bankAccountManager.Update(bankAccount);
                    await loadCheckVoucherNumbers();
                    dgvPayables.Rows.Clear();
                    tbxCheckNumber.Text = "0000000";
                    tbxCheckVoucherNumber.Text = string.Empty;
                    tbxPayee.Text = string.Empty;
                    payee = null;
                    cmbxBanks.SelectedItem = null;
                    cmbxBankAccounts.Items.Clear();
                    tbxGrandTotal.Text = "0.00";
                    clearCheckVoucherNumber();
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
