using Citicon.Data;
using Citicon.DataManager;
using Citicon.Inventory.Data;
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

        private Branch[] branches;
        private Company[] companies;
        private Expense[] expenses;
        private Supplier[] suppliers;

        private bool addedSuccessfully;

        private List<Payable> exportablePayables;

        public ChequeVoucherForm()
        {
            InitializeComponent();

            branchManager = new BranchManager();
            branchManager.ExceptionCatched += ExceptionCatched;
            branchManager.NewItemGenerated += BranchManager_NewItemGenerated;

            companyManager = new CompanyManager();
            companyManager.ExceptionCatched += ExceptionCatched;
            companyManager.NewItemGenerated += CompanyManager_NewItemGenerated;

            expenseManager = new ExpenseManager();
            expenseManager.ExceptionCatched += ExceptionCatched;
            expenseManager.NewItemGenerated += ExpenseManager_NewItemGenerated;

            payableManager = new PayableManager();
            payableManager.ExceptionCatched += ExceptionCatched;
            payableManager.Added += PayableManager_Added;
            payableManager.AddedUnsuccessful += PayableManager_AddedUnsuccessful;

            stockManager = new StockManager();
            stockManager.ExceptionCatched += ExceptionCatched;
            stockManager.NewUnpaidMrisNumberGenerated += StockManager_NewUnpaidMrisNumberGenerated;
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

        private void ExpenseManager_NewItemGenerated(Expense e)
        {
            Invoke(new Action(() => tbxExpenseExpense.AutoCompleteCustomSource.Add(e.Description)));
        }

        private void CompanyManager_NewItemGenerated(Company e)
        {
            Invoke(new Action(() => tbxExpenseCompany.AutoCompleteCustomSource.Add(e.Description)));
        }

        private void BranchManager_NewItemGenerated(Branch e)
        {
            Invoke(new Action(() => tbxExpenseBranch.AutoCompleteCustomSource.Add(e.Description)));
        }

        private void SupplierManager_NewItemGenerated(Supplier e)
        {
            Invoke(new Action(() => tbxExpenseSupplier.AutoCompleteCustomSource.Add(e.Description)));
        }

        private async Task loadSuppliers()
        {
            tbxExpenseSupplier.AutoCompleteCustomSource.Clear();
            suppliers = await supplierManager.GetListAsync();
        }

        private async Task loadCompanies()
        {
            tbxExpenseCompany.AutoCompleteCustomSource.Clear();
            companies = await companyManager.GetListAsync();
        }

        private async Task loadExpenses()
        {
            tbxExpenseExpense.AutoCompleteCustomSource.Clear();
            expenses = await expenseManager.GetListAsync();
        }

        private async Task loadBranches()
        {
            tbxExpenseBranch.AutoCompleteCustomSource.Clear();
            branches = await branchManager.GetListAsync();
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
                }
                if (activeSupplier == e.Supplier)
                {
                    foreach (DataGridViewRow row in dgvStocks.Rows) if (((Stock)row.Cells[colStocks.Name].Value) == e) return;
                    dgvStocks.Rows.Add(e, e.MrisNumber, e.Company, e.Branch, (e.UnitPrice * e.AddedStockValue).ToString("#,##0.00"));
                }
            }));
        }

        private void StockManager_NewItemGenerated(Stock e)
        {
            
        }

        private void StockManager_NewUnpaidMrisNumberGenerated(string e)
        {
            Invoke(new Action(() => tbxSearchMrisNumber.AutoCompleteCustomSource.Add(e)));
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private async void ChequeVoucherForm_Load(object sender, EventArgs e)
        {
            await loadMrisSuggest();
            await loadSuppliers();
            await loadBranches();
            await loadCompanies();
            await loadExpenses();
            generateChequeVoucherNumber();
        }

        private void generateChequeVoucherNumber()
        {
            tbxCheckVoucherNumber.Text = payableManager.GenerateChequeVoucherNumber();
        }

        private async Task loadMrisSuggest()
        {
            tbxSearchMrisNumber.AutoCompleteCustomSource.Clear();
            await stockManager.GetUnpaidMrisNumberListAsync();
        }

        private void countGrandTotal()
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
                foreach (DataGridViewRow row in dgvExpenses.Rows)
                {
                    var payable = (Payable)row.Cells[colExpense.Name].Value;
                    total += payable.TotalAmount;
                }
            }
            tbxGrandTotal.Text = total.ToString("#,##0.00");
        }

        private async void tbxSearchMrisNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await getStocksByMrisNumber();
            }
        }

        private async Task getStocksByMrisNumber()
        {
            await stockManager.GetListByMrisNumberAsync(tbxSearchMrisNumber.Text.Trim());
            countGrandTotal();
        }

        private async void btnSearchMrisNumber_Click(object sender, EventArgs e)
        {
            await getStocksByMrisNumber();
        }

        private void tcChequeVoucher_Selected(object sender, TabControlEventArgs e)
        {
            countGrandTotal();
        }

        private void clearActiveSupplier()
        {
            activeSupplier = null;
            tbxActiveSupplier.Text = string.Empty;
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStocks.Rows)
            {
                var mrisNumber = ((Stock)row.Cells[colStocks.Name].Value).MrisNumber;
                if (!tbxSearchMrisNumber.AutoCompleteCustomSource.Contains(mrisNumber)) tbxSearchMrisNumber.AutoCompleteCustomSource.Add(mrisNumber);
            }
            dgvStocks.Rows.Clear();
            clearActiveSupplier();
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
                    if (dgvStocks.Rows.Count == 1) clearActiveSupplier();
                    dgvStocks.Rows.Remove(row);
                }
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (dgvStocks.SelectedRows.Count == 1)
            {
                var row = dgvStocks.SelectedRows[0];
                var mrisNumber = ((Stock)row.Cells[colStocks.Name].Value).MrisNumber;
                if (!tbxSearchMrisNumber.AutoCompleteCustomSource.Contains(mrisNumber)) tbxSearchMrisNumber.AutoCompleteCustomSource.Add(mrisNumber);
                if (dgvStocks.Rows.Count == 1) clearActiveSupplier();
                dgvStocks.Rows.Remove(row);
            }
        }

        private async void btnExportCheque_Click(object sender, EventArgs e)
        {
            exportablePayables = new List<Payable>();
            addedSuccessfully = true;
            if (tcChequeVoucher.SelectedTab == tpVariableCost)
            {
                var chequeVoucherNumber = tbxCheckVoucherNumber.Text.Trim();
                foreach (DataGridViewRow row in dgvStocks.Rows)
                {
                    var stock = (Stock)row.Cells[colStocks.Name].Value;
                    var payable = new Payable
                    {
                        BankAccount = null,
                        Branch = stock.Branch,
                        ChequeNumber = null,
                        ChequeVoucherNumber = chequeVoucherNumber,
                        Company = stock.Company,
                        Description = stock.Item.Description,
                        Expense = null,
                        Id = 0,
                        SalaryPeriodEnd = default(DateTime),
                        SalaryPeriodStart = default(DateTime),
                        Stock = stock,
                        Supplier = activeSupplier,
                        TotalAmount = stock.AddedStockValue * stock.UnitPrice,
                        VariableCost = true,
                        Remarks = $"Payment for {stock.Item.Description} as per SIDR No. {stock.SidrNumber} dated {stock.DeliveryDate.ToString("MMM dd, yyyy")}."
                    };
                    stock.Paid = true;
                    stockManager.Update(stock);
                    payableManager.Add(payable);
                }
                dgvStocks.Rows.Clear();
            }
            else if (tcChequeVoucher.SelectedTab == tpExpenses)
            {
                foreach (DataGridViewRow row in dgvExpenses.Rows)
                {
                    payableManager.Add((Payable)row.Cells[colExpense.Name].Value);
                }
                clearActiveExpenseSupplier();
                dgvExpenses.Rows.Clear();
            }
            await loadMrisSuggest();
            generateChequeVoucherNumber();
            if (addedSuccessfully) MessageBox.Show("Payables have been saved successfully!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Some or all payables are not saved successfully!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (exportablePayables.Count > 0)
            {
                try
                {
                    payableManager.ExportChequeVoucher(exportablePayables.ToArray());
                }
                catch (Exception ex)
                {
                    displayError(ex.Message);
                }
            }
        }

        private void btnExpenseAdd_Click(object sender, EventArgs e)
        {
            if (activeExpenseSupplier != null)
            {
                var expense = expenses.Where(x => x.Description == tbxExpenseExpense.Text.Trim()).FirstOrDefault();
                var company = companies.Where(x => x.Description == tbxExpenseCompany.Text.Trim()).FirstOrDefault();
                var branch = branches.Where(x => x.Description == tbxExpenseBranch.Text.Trim()).FirstOrDefault();
                var salaryPeriodStart = dtpExpenseSalaryPeriodStart.Value;
                var salaryPeriodEnd = dtpExpenseSalaryPeriodEnd.Value;
                var totalAmount = nudExpenseAmount.Value;
                var description = expense.Description;
                var remarks = tbxExpenseRemarks.Text.Trim();
                if (expense == null) { displayError("Expenses type is invalid!"); return; }
                if (company == null) { displayError("Company is invalid!"); return; }
                if (branch == null) { displayError("Branch is invalid!"); return; }
                if (totalAmount == 0) { displayError("Total Amount is invalid!"); return; }
                if (description == string.Empty) { displayError("Description should not be empty!"); return; }
                if (expense != Expense.Salary)
                {
                    salaryPeriodEnd = default(DateTime);
                    salaryPeriodStart = default(DateTime);
                }
                foreach (DataGridViewRow row in dgvExpenses.Rows)
                {
                    var x = (Payable)row.Cells[colExpense.Name].Value;
                    if (x.Company == company && x.Branch == branch && x.TotalAmount == totalAmount) { displayError("Payable already exists!"); return; }
                }
                var payable = new Payable
                {
                    Branch = branch,
                    ChequeVoucherNumber = tbxCheckVoucherNumber.Text.Trim(),
                    Company = company,
                    Description = description,
                    Expense = expense,
                    SalaryPeriodEnd = salaryPeriodEnd,
                    SalaryPeriodStart = salaryPeriodStart,
                    Stock = null,
                    Supplier = activeExpenseSupplier,
                    TotalAmount = totalAmount,
                    VariableCost = false,
                    BankAccount = null,
                    ChequeNumber = null,
                    Id = 0,
                    Remarks = remarks
                };
                dgvExpenses.Rows.Add(payable, company, branch, totalAmount.ToString("#,##0.00"));
                clearPayableFields();
                countGrandTotal();
            }
            else displayError("Supplier should be valid!");
        }

        private void displayError(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void clearActiveExpenseSupplier()
        {
            activeExpenseSupplier = null;
            tbxExpenseSupplier.ForeColor = Color.Black;
            tbxExpenseSupplier.BackColor = Color.White;
        }

        private void setActiveExpenseSupplier()
        {
            activeExpenseSupplier = suppliers.Where(x => x.Description == tbxExpenseSupplier.Text.Trim()).FirstOrDefault();
            if (activeExpenseSupplier != null)
            {
                tbxExpenseSupplier.ForeColor = Color.FromArgb(255, 128, 0);
                tbxExpenseSupplier.BackColor = Color.FromArgb(40, 40, 40);
            }
            else clearActiveExpenseSupplier();
        }

        private void btnChangeExpenseSupplier_Click(object sender, EventArgs e)
        {
            clearActiveExpenseSupplier();
        }

        private void tbxExpenseSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) setActiveExpenseSupplier();
        }

        private void tbxExpenseSupplier_Leave(object sender, EventArgs e)
        {
            setActiveExpenseSupplier();
        }

        private void clearPayableFields()
        {
            tbxExpenseBranch.Text = string.Empty;
            tbxExpenseCompany.Text = string.Empty;
            tbxExpenseExpense.Text = string.Empty;
            nudExpenseAmount.Value = 0.00M;
            dtpExpenseSalaryPeriodEnd.Value = DateTime.Now;
            dtpExpenseSalaryPeriodStart.Value = DateTime.Now;
            tbxExpenseRemarks.Text = string.Empty;
        }

        private void btnExpenseCancel_Click(object sender, EventArgs e)
        {
            clearPayableFields();
        }

        private void tbxExpenseExpense_TextChanged(object sender, EventArgs e)
        {
            setExpenseRemarks();
        }

        private void setExpenseRemarks()
        {
            if (tbxExpenseExpense.Text.Trim() == Expense.Salary.Description)
                tbxExpenseRemarks.Text = $"Payment for {Expense.Salary.Description} expenses for the period of {dtpExpenseSalaryPeriodStart.Value.ToString("MMMM dd, yyyy")} to {dtpExpenseSalaryPeriodEnd.Value.ToString("MMMM dd, yyyy")}";
            else tbxExpenseRemarks.Text = $"Payment for {tbxExpenseExpense.Text.Trim()} expenses dated {DateTime.Now.ToString("MMM dd, yyyy")}.";

        }

        private void dtpExpenseSalaryPeriodStart_ValueChanged(object sender, EventArgs e)
        {
            setExpenseRemarks();
        }

        private void dtpExpenseSalaryPeriodEnd_ValueChanged(object sender, EventArgs e)
        {
            setExpenseRemarks();
        }
    }
}
