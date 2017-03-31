using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Windows.Forms;

namespace Citicon.Payables
{
    public partial class ReportsForm : Form
    {
        PayableManager payableManager;
        CompanyManager companyManager;
        BranchManager branchManager;
        ClassificationManager classificationManager;
        ExpenseManager expenseManager;
        SupplierManager supplierManager;
        public ReportsForm()
        {
            InitializeComponent();
            payableManager = new PayableManager();
            companyManager = new CompanyManager();
            branchManager = new BranchManager();
            classificationManager = new ClassificationManager();
            expenseManager = new ExpenseManager();
            supplierManager = new SupplierManager();
            payableManager.ExceptionCatched += ExceptionCatched;
            companyManager.ExceptionCatched += ExceptionCatched;
            branchManager.ExceptionCatched += ExceptionCatched;
            classificationManager.ExceptionCatched += ExceptionCatched;
            expenseManager.ExceptionCatched += ExceptionCatched;
            supplierManager.ExceptionCatched += ExceptionCatched;
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private void btnTransactionsGenerate_Click(object sender, EventArgs e)
        {
            btnTransactionsGenerate.Enabled = false;
            var transactionDateStart = dtpTransactionsTransactionDateStart.Value;
            var transactionDateEnd = dtpTransactionsTransactionDateEnd.Value;
            var branch = (Branch)cmbxTransactionsBranch.SelectedItem;
            var company = (Company)cmbxTransactionsCompany.SelectedItem;
            var itemClassification = (Classification)cmbxTransactionsItemClassification.SelectedItem;
            var expense = (Expense)cmbxTransactionsExpense.SelectedItem;
            var supplier = (Supplier)cmbxTransactionsSupplier.SelectedItem;
            var task = payableManager.GetTransactionsAsync(
                ckbxTransactionsTransactionDate.Checked, transactionDateStart, transactionDateEnd,
                ckbxTransactionsCompany.Checked, company,
                ckbxTransactionsBranch.Checked, branch,
                ckbxTransactionsItemClassification.Checked, itemClassification,
                ckbxTransactionsExpense.Checked, expense,
                ckbxTransactionsSupplier.Checked, supplier);
            dgvTransactions.Rows.Clear();
            task.ContinueWith(x =>
            {
                if (task.Result != null)
                {
                    foreach (var item in task.Result)
                    {
                        Invoke(new Action(() =>
                        {
                            dgvTransactions.Rows.Add(
                                item,
                                item.VariableCost
                                    ? item.Stock?.Item?.Classification.ToString() 
                                    : item.Expense?.ToString(),
                                item.Debit.ToString("#,##0.00"),
                                item.ChequeNumber,
                                item.Supplier,
                                item.TransactionDate.ToString("MMMM dd, yyyy"));
                            
                        }));
                    }
                }
                Invoke(new Action(() => btnTransactionsGenerate.Enabled = true));
            });
            
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            cmbxTransactionsBranch.Items.AddRange(branchManager.GetListAsync().Result);
            cmbxTransactionsCompany.Items.AddRange(companyManager.GetListAsync().Result);
            cmbxTransactionsItemClassification.Items.AddRange(classificationManager.GetListAsync().Result);
            cmbxTransactionsExpense.Items.AddRange(expenseManager.GetListAsync().Result);
            cmbxTransactionsSupplier.Items.AddRange(supplierManager.GetListAsync().Result);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Transactions_CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            var ckbx = (CheckBox)sender;
            foreach (Control c in tpTransactions.Controls)
            {
                if (ckbx.Tag == c.Tag && c != ckbx) c.Enabled = ckbx.Checked;
            }
        }

        private void ChequeReports_Load(object sender, EventArgs e)
        {
            
        }
    }
}
