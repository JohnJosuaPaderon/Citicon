using Citicon.Data;
using Citicon.Data.Converters;
using Citicon.DataManager;
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
    public partial class ChequeVoucherForm : Form
    {
        private BranchManager branchManager;
        private CompanyManager companyManager;
        private ExpenseManager expenseManager;
        private PayableManager payableManager;
        private StockManager stockManager;
        private SupplierManager supplierManager;

        private Supplier activeSupplier;
        private Supplier activeExpenseSupplier;

        private Supplier[] suppliers;

        private bool addedSuccessfully;

        private List<Payable> exportablePayables;

        public ChequeVoucherForm()
        {
            InitializeComponent();

            branchManager = new BranchManager();
            branchManager.ExceptionCatched += ExceptionCatched;

            companyManager = new CompanyManager();
            companyManager.ExceptionCatched += ExceptionCatched;

            expenseManager = new ExpenseManager();
            expenseManager.ExceptionCatched += ExceptionCatched;

            payableManager = new PayableManager();
            payableManager.ExceptionCatched += ExceptionCatched;
            payableManager.Added += PayableManager_Added;
            payableManager.AddedUnsuccessful += PayableManager_AddedUnsuccessful;

            stockManager = new StockManager();
            stockManager.ExceptionCatched += ExceptionCatched;
            //stockManager.NewUnpaidMrisNumberGenerated += StockManager_NewUnpaidMrisNumberGenerated;
            stockManager.NewItemGenerated += StockManager_NewItemGenerated;
            stockManager.NewItemByMrisNumberGenerated += StockManager_NewItemByMrisNumberGenerated;

            supplierManager = new SupplierManager();
            supplierManager.ExceptionCatched += ExceptionCatched;
            supplierManager.NewItemGenerated += SupplierManager_NewItemGenerated;
        }

        private void PayableManager_AddedUnsuccessful(Payable e)
        {
            addedSuccessfully &= false;
        }

        private void PayableManager_Added(Payable e)
        {
            addedSuccessfully &= true;
            exportablePayables.Add(e);
        }

        private void SupplierManager_NewItemGenerated(Supplier e)
        {
            Invoke(new Action(() => tbxExpenseSupplier.AutoCompleteCustomSource.Add(e.Description)));
        }

        private async Task LoadSuppliers()
        {
            tbxExpenseSupplier.AutoCompleteCustomSource.Clear();
            suppliers = await supplierManager.GetListAsync();

            foreach (var item in suppliers)
            {
                tbxExpenseSupplier.AutoCompleteCustomSource.Add(item.ToString());
            }
        }

        private void StockManager_NewItemByMrisNumberGenerated(Stock e)
        {
            Invoke(new Action(() =>
            {
                if (tbxSearchMrisNumber.AutoCompleteCustomSource.Contains(e.MrisNumber))
                {
                    tbxSearchMrisNumber.AutoCompleteCustomSource.Remove(e.MrisNumber);
                    tbxSearchMrisNumber.Text = string.Empty;
                }
                if (activeSupplier == null)
                {
                    activeSupplier = e.Supplier;
                    tbxActiveSupplier.Text = activeSupplier.Description;
                    tbxActiveSupplier.BackColor = Color.FromArgb(64, 64, 64);
                }
                if (activeSupplier == e.Supplier)
                {
                    foreach (DataGridViewRow row in dgvStocks.Rows) if (((Stock)row.Cells[colStocks.Name].Value) == e) return;
                    if (!e.Paid) dgvStocks.Rows.Add(e, e.MrisNumber, e.Company, e.Branch, (e.UnitPrice * e.AddedStockValue).ToString("#,##0.00"));
                }
            }));
        }

        private void StockManager_NewItemGenerated(Stock e)
        {
            
        }

        private void StockManager_NewUnpaidMrisNumberGenerated(string e)
        {
            //Invoke(new Action(() => tbxSearchMrisNumber.AutoCompleteCustomSource.Add(e)));
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private async void ChequeVoucherForm_Load(object sender, EventArgs e)
        {
            await LoadMrisSuggest();
            await LoadSuppliers();
            LoadExpenses();
            LoadCompanies();
            LoadBranches();
            GenerateChequeVoucherNumber();

            cmbxVariableCostAccountType.Items.Add(PayableTypeConverter.ToDisplay(PayableType.Trade));
            cmbxVariableCostAccountType.Items.Add(PayableTypeConverter.ToDisplay(PayableType.NonTrade));
        }

        private void GenerateChequeVoucherNumber()
        {
            tbxCheckVoucherNumber.Text = payableManager.GenerateChequeVoucherNumber();
        }

        private void LoadExpenses()
        {
            var task = expenseManager.GetListAsync();
            task.ContinueWith(x =>
            {
                Invoke(new Action(() =>
                {
                    cmbxExpensesExpense.Items.Clear();
                    cmbxExpensesExpense.Items.AddRange(x.Result);
                }));
            });
        }

        private void LoadCompanies()
        {
            var task = companyManager.GetListAsync();
            task.ContinueWith(x =>
            {
                Invoke(new Action(() =>
                {
                    cmbxExpenseCompany.Items.Clear();
                    cmbxExpenseCompany.Items.AddRange(x.Result);
                }));
            });
        }

        private void LoadBranches()
        {
            var task = branchManager.GetListAsync();
            task.ContinueWith(x =>
            {
                Invoke(new Action(() =>
                {
                    cmbxExpenseBranch.Items.Clear();
                    cmbxExpenseBranch.Items.AddRange(x.Result);
                }));
            });
        }

        private async Task LoadMrisSuggest()
        {
            tbxSearchMrisNumber.AutoCompleteCustomSource.Clear();
            var list = await stockManager.GetUnpaidMrisNumberListAsync();
            tbxSearchMrisNumber.AutoCompleteCustomSource.AddRange(list);
        }

        private void CountGrandTotal()
        {
            decimal total = 0;
            if (tcChequeVoucher.SelectedTab == tpVariableCost)
            {
                foreach (DataGridViewRow row in dgvStocks.Rows)
                {
                    var stock = (Stock)row.Cells[colStocks.Name].Value;
                    total += stock.UnitPrice * stock.AddedStockValue;
                }
            }
            else if (tcChequeVoucher.SelectedTab == tpExpenses)
            {
                decimal totalDebit = 0;
                decimal totalCredit = 0;
                //decimal cashInBank = 0;

                foreach (DataGridViewRow row in dgvExpenses.Rows)
                {

                    var expense = row.Cells[colExpense.Name].Value as Expense;

                    decimal.TryParse(row.Cells[colExpenseDebit.Name].Value.ToString().Replace(",", string.Empty), out decimal debit);
                    decimal.TryParse(row.Cells[colExpenseCredit.Name].Value.ToString().Replace(",", string.Empty), out decimal credit);
                    
                    totalDebit += debit;
                    totalCredit += credit;

                    if (expense == Expense.CashInBank)
                    {
                        total += credit;
                    }
                }
                tbxExpenseTotalDebit.Text = totalDebit.ToString("#,##0.00");
                tbxExpenseTotalCredit.Text = totalCredit.ToString("#,##0.00");
            }

            tbxGrandTotal.Text = total.ToString("#,##0.00");
        }

        private async void tbxSearchMrisNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await GetStocksByMrisNumber();
            }
        }

        private async Task GetStocksByMrisNumber()
        {
            await stockManager.GetListByMrisNumberAsync(tbxSearchMrisNumber.Text.Trim());
            CountGrandTotal();
        }

        private async void btnSearchMrisNumber_Click(object sender, EventArgs e)
        {
            await GetStocksByMrisNumber();
        }

        private void tcChequeVoucher_Selected(object sender, TabControlEventArgs e)
        {
            CountGrandTotal();
        }

        private void ClearActiveSupplier()
        {
            activeSupplier = null;
            tbxActiveSupplier.BackColor = Color.White;
            tbxActiveSupplier.Text = string.Empty;
            CountGrandTotal();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStocks.Rows)
            {
                var mrisNumber = ((Stock)row.Cells[colStocks.Name].Value).MrisNumber;
                if (!tbxSearchMrisNumber.AutoCompleteCustomSource.Contains(mrisNumber)) tbxSearchMrisNumber.AutoCompleteCustomSource.Add(mrisNumber);
            }
            CountGrandTotal();
            dgvStocks.Rows.Clear();
            ClearActiveSupplier();
        }

        private void btnRemoveSameMrisNumber_Click(object sender, EventArgs e)
        {
            if (dgvStocks.SelectedRows.Count == 1)
            {
                var mrisNumber = ((Stock)dgvStocks.SelectedRows[0].Cells[colStocks.Name].Value).MrisNumber;
                tbxSearchMrisNumber.AutoCompleteCustomSource.Add(mrisNumber);
                var rowsToBeRemoved = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dgvStocks.Rows)
                    if (((Stock)row.Cells[colStocks.Name].Value).MrisNumber == mrisNumber)
                        rowsToBeRemoved.Add(row);
                foreach (var row in rowsToBeRemoved)
                {
                    if (dgvStocks.Rows.Count == 1) ClearActiveSupplier();
                    dgvStocks.Rows.Remove(row);
                }
                CountGrandTotal();
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (dgvStocks.SelectedRows.Count == 1)
            {
                var row = dgvStocks.SelectedRows[0];
                var mrisNumber = ((Stock)row.Cells[colStocks.Name].Value).MrisNumber;
                if (!tbxSearchMrisNumber.AutoCompleteCustomSource.Contains(mrisNumber)) tbxSearchMrisNumber.AutoCompleteCustomSource.Add(mrisNumber);
                if (dgvStocks.Rows.Count == 1) ClearActiveSupplier();
                dgvStocks.Rows.Remove(row);
                CountGrandTotal();
            }
        }

        private async void btnExportCheque_Click(object sender, EventArgs e)
        {
            GenerateChequeVoucherNumber();
            var variableCost = true;

            if (dgvExpenses.Rows.Count > 0 || dgvStocks.Rows.Count > 0)
            {
                exportablePayables = new List<Payable>();
                addedSuccessfully = true;
                string accountType = (string)cmbxVariableCostAccountType.SelectedItem;
                var chequeVoucherNumber = tbxCheckVoucherNumber.Text.Trim();
                if (tcChequeVoucher.SelectedTab == tpVariableCost)
                {
                    variableCost = true;
                    if (cmbxVariableCostAccountType.SelectedItem != null)
                    {
                        Branch withHoldingTax_Branch = null;
                        Company withHoldingTax_Company = null;
                        decimal withHoldingTax_Value = 0;
                        Expense withHoldingTax = expenseManager.GetById(Convert.ToUInt64(ConfigurationManager.AppSettings["WithHoldingTax_Id"]));
                        foreach (DataGridViewRow row in dgvStocks.Rows)
                        {
                            var stock = (Stock)row.Cells[colStocks.Name].Value;

                            if (withHoldingTax_Branch == null)
                            {
                                withHoldingTax_Branch = stock.Branch;
                            }

                            if (withHoldingTax_Company == null)
                            {
                                withHoldingTax_Company = stock.Company;
                            }

                            if (stock.IncludeWithHoldingTax)
                            {
                                var withHoldingTaxValue = stock.WithHoldingTax ?? 1;
                                withHoldingTax_Value += (((stock.UnitPrice * stock.AddedStockValue) / ((withHoldingTaxValue != 0) ? withHoldingTaxValue : 1)) * 0.12M);
                            }

                            var payable = new Payable
                            {
                                BankAccount = null,
                                Branch = stock.Branch,
                                ChequeNumber = null,
                                ChequeVoucherNumber = chequeVoucherNumber,
                                Company = stock.Company,
                                Description = stock.Item?.Description,
                                Expense = null,
                                Id = 0,
                                SalaryPeriodEnd = default(DateTime),
                                SalaryPeriodStart = default(DateTime),
                                Stock = stock,
                                Supplier = activeSupplier,
                                Debit = stock.AddedStockValue * stock.UnitPrice,
                                VariableCost = true,
                                Remarks = rtbxRemarks.Text,
                                AccountType = accountType,
                                TransactionDate = DateTime.Now
                                //Remarks = $"Payment for {stock.Item?.Description} as per SIDR No. {stock.SiNumber} dated {stock.DeliveryDate.ToString("MMM dd, yyyy")}."
                            };
                            stock.Paid = true;
                            stockManager.Update(stock);
                            payableManager.Add(payable);
                        }
                        var withHoldingTaxPayable = new Payable
                        {
                            BankAccount = null,
                            AccountType = accountType,
                            Branch = withHoldingTax_Branch,
                            ChequeNumber = null,
                            ChequeVoucherNumber = chequeVoucherNumber,
                            Company = withHoldingTax_Company,
                            Credit = 0,
                            Debit = withHoldingTax_Value,
                            Description = withHoldingTax.Description,
                            Expense = withHoldingTax,
                            Id = 0,
                            Remarks = null,
                            SalaryPeriodEnd = default(DateTime),
                            SalaryPeriodStart = default(DateTime),
                            Stock = null,
                            Supplier = activeSupplier,
                            TransactionDate = DateTime.Now,
                            VariableCost = true
                        };
                        payableManager.Add(withHoldingTaxPayable);
                        dgvStocks.Rows.Clear();
                    }
                    else
                    {
                        DisplayError("Select an Account Payables Type!");
                        return;
                    }
                }
                else if (tcChequeVoucher.SelectedTab == tpExpenses)
                {
                    variableCost = false;
                    var _credit = decimal.Parse(tbxExpenseTotalCredit.Text.Replace(",", string.Empty));
                    var _debit = decimal.Parse(tbxExpenseTotalDebit.Text.Replace(",", string.Empty));
                    if (_credit == _debit)
                    {
                        var payables = new List<Payable>();
                        var cashInBank = Expense.CashInBank;
                        Payable cashInBankPayable = null;

                        foreach (DataGridViewRow row in dgvExpenses.Rows)
                        {
                            var branch = (Branch)row.Cells[colExpenseBranch.Name].Value;
                            var company = (Company)row.Cells[colExpenseCompany.Name].Value;
                            var credit = decimal.Parse(row.Cells[colExpenseCredit.Name].Value.ToString().Replace(",", string.Empty));
                            var debit = decimal.Parse(row.Cells[colExpenseDebit.Name].Value.ToString().Replace(",", string.Empty));
                            var expense = (Expense)row.Cells[colExpense.Name].Value;

                            var payable = new Payable
                            {
                                BankAccount = null,
                                Branch = branch,
                                ChequeNumber = null,
                                ChequeVoucherNumber = chequeVoucherNumber,
                                Company = company,
                                Credit = credit,
                                Debit = debit,
                                Description = expense?.Description,
                                Expense = expense,
                                Id = 0,
                                Remarks = tbxExpenseRemarks.Text,
                                SalaryPeriodEnd = default(DateTime),
                                SalaryPeriodStart = default(DateTime),
                                Stock = null,
                                Supplier = activeExpenseSupplier,
                                TransactionDate = DateTime.Now,
                                VariableCost = false
                            };

                            if (payable.Expense.Id == cashInBank.Id)
                            {
                                cashInBankPayable = payable;
                            }
                            else
                            {
                                payables.Add(payable);
                            }
                        }

                        foreach (var item in payables)
                        {
                            //cashInBankPayable.Credit -= item.Credit;
                            payableManager.Add(item);
                        }

                        payableManager.Add(cashInBankPayable);

                        ClearActiveExpenseSupplier();
                        dgvExpenses.Rows.Clear();
                    }
                    else
                    {
                        DisplayError("Debit and Credit is not balanced!");
                        return;
                    }
                }
                await LoadMrisSuggest();
                GenerateChequeVoucherNumber();
                if (addedSuccessfully)
                {
                    rtbxRemarks.Text = string.Empty;
                    MessageBox.Show("Payables have been saved successfully!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Some or all payables are not saved successfully!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (exportablePayables.Count > 0)
                {
                    
                    try
                    {
                        string accountPayableType = string.Empty;
                        if (tcChequeVoucher.SelectedTab == tpVariableCost)
                        {
                            accountPayableType = (string)cmbxVariableCostAccountType.SelectedItem;
                            var expense = expenseManager.GetById(76);
                            payableManager.Add(new Payable
                            {
                                BankAccount = null,
                                Branch = new Branch(),
                                ChequeNumber = null,
                                Company = new Company(),
                                ChequeVoucherNumber = chequeVoucherNumber,
                                Credit = decimal.Parse(tbxGrandTotal.Text.Replace(",", "")),
                                Debit = 0,
                                Description = expense?.Description,
                                Expense = expense,
                                Id = 0,
                                Remarks = null,
                                SalaryPeriodEnd = DateTime.Now,
                                SalaryPeriodStart = DateTime.Now,
                                Stock = null,
                                Supplier = activeSupplier,
                                TransactionDate = default(DateTime),
                                VariableCost = false
                            });
                        }
                        ClearActiveSupplier();

                        var exportOption = ConfigurationManager.AppSettings["ChequeVoucher.ExportOption"];

                        if (exportOption == "V2")
                        {
                            var chequeVoucher = new ChequeVoucher(variableCost, PayableTypeConverter.FromDisplay((string)cmbxVariableCostAccountType.SelectedItem));
                            chequeVoucher.Payables.AddRange(exportablePayables);
                            chequeVoucher.RefreshData();
                            await payableManager.ExportChequeVoucherAsync(chequeVoucher);
                        }
                        else
                        {
                            payableManager.ExportChequeVoucher(exportablePayables.ToArray(), accountPayableType);
                        }
                    }
                    catch (Exception ex)
                    {
                        DisplayError(ex.Message);
                    }
                }
            }
        }

        private void DisplayError(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearActiveExpenseSupplier()
        {
            activeExpenseSupplier = null;
            tbxExpenseSupplier.ForeColor = Color.Black;
            tbxExpenseSupplier.BackColor = Color.White;
            tbxExpenseSupplier.Text = string.Empty;
            dgvExpenses.Rows.Clear();
            CountGrandTotal();
        }

        private void SetActiveExpenseSupplier()
        {
            activeExpenseSupplier = suppliers.Where(x => x.Description == tbxExpenseSupplier.Text.Trim()).FirstOrDefault();
            if (activeExpenseSupplier != null)
            {
                tbxExpenseSupplier.ForeColor = Color.FromArgb(255, 192, 192);
                tbxExpenseSupplier.BackColor = Color.FromArgb(40, 40, 40);
            }
            else ClearActiveExpenseSupplier();
        }

        private void btnChangeExpenseSupplier_Click(object sender, EventArgs e)
        {
            ClearActiveExpenseSupplier();
        }

        private void tbxExpenseSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SetActiveExpenseSupplier();
        }

        private void tbxExpenseSupplier_Leave(object sender, EventArgs e)
        {
            SetActiveExpenseSupplier();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblChequeVoucher_Click(object sender, EventArgs e)
        {

        }

        private void tpExpenses_Click(object sender, EventArgs e)
        {

        }

        private void cmbxExpensesExpense_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cmbxExpensesExpense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var x = cmbxExpensesExpense.SelectedItem;
                cmbxExpensesExpense.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void cmbxExpensesExpense_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmbxExpensesExpense.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (cmbxExpensesExpense.SelectedItem == null)
            {
                DisplayError("Select an expense first!");
                return;
            }
            else if (cmbxExpenseBranch.SelectedItem == null)
            {
                DisplayError("Select a branch first!");
                return;
            }
            else if (cmbxExpenseCompany.SelectedItem == null)
            {
                DisplayError("Select a company first!");
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = cmbxExpensesExpense.SelectedItem });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = cmbxExpenseCompany.SelectedItem });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = cmbxExpenseBranch.SelectedItem });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = 0 });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = 0 });
            row.Height = 30;
            dgvExpenses.Rows.Add(row);
            cmbxExpenseBranch.SelectedItem = null;
            cmbxExpenseCompany.SelectedItem = null;
            cmbxExpensesExpense.SelectedItem = null;
        }

        private void dgvExpenses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == colExpenseCredit.Index || e.ColumnIndex == colExpenseDebit.Index))
            {
                var cell = dgvExpenses.Rows[e.RowIndex].Cells[e.ColumnIndex];
                decimal x;
                decimal.TryParse(cell.Value.ToString(), out x);
                cell.Value = x.ToString("#,##0.00");
                CountGrandTotal();
            }

        }

        private void tbxExpenseTotalCredit_TextChanged(object sender, EventArgs e)
        {
            CountExpenseDiffence();
        }

        private void tbxExpenseTotalDebit_TextChanged(object sender, EventArgs e)
        {
            CountExpenseDiffence();
        }

        private void CountExpenseDiffence()
        {
            decimal debit;
            decimal credit;

            decimal.TryParse(tbxExpenseTotalDebit.Text.Trim(), out debit);
            decimal.TryParse(tbxExpenseTotalCredit.Text.Trim(), out credit);
            tbxExpenseDifference.Text = (debit - credit).ToString("#,##0.00");
            //if (debit == credit)
            //    tbxGrandTotal.Text = debit.ToString("#,##0.00");
        }

        private void tbxExpenseDifference_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblVariableCostRemarks_Click(object sender, EventArgs e)
        {

        }

        private void tpVariableCost_Click(object sender, EventArgs e)
        {

        }

        private void dgvStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemoveSelectedExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count > 0)
            {
                dgvExpenses.Rows.Remove(dgvExpenses.SelectedRows[0]);
                CountGrandTotal();
            }
        }
    }
}
