using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Payables.Reports
{
    public partial class ChequeReportFilter : UserControl
    {
        public ChequeReportFilter()
        {
            InitializeComponent();
        }

        private SupplierManager SupplierManager;
        private BranchManager BranchManager;
        private CompanyManager CompanyManager;
        public Action<bool> HasFiltered { get; set; }

        private bool _FilterByRangeDate;
        private bool _FilterBySupplier;
        private bool _FilterByBranch;
        private bool _FilterByCompany;
        private bool _FilterByTransactionDate;

        public bool FilterByRangeDate
        {
            get { return _FilterByRangeDate; }
            private set
            {
                if (_FilterByRangeDate != value)
                {
                    _FilterByRangeDate = value;
                    pnlRangeDate.Enabled = value;
                    OnHasFiltered();
                }
            }
        }
        public bool FilterBySupplier
        {
            get { return _FilterBySupplier; }
            private set
            {
                if (_FilterBySupplier != value)
                {
                    _FilterBySupplier = value;
                    cmbxSupplier.Enabled = value;
                    OnHasFiltered();
                }
            }
        }
        
        public bool FilterByBranch
        {
            get { return _FilterByBranch; }
            private set
            {
                if (_FilterByBranch != value)
                {
                    _FilterByBranch = value;
                    FilterByBranchComboBox.Enabled = value;
                    OnHasFiltered();
                }
            }
        }

        public bool FilterByCompany
        {
            get { return _FilterByCompany; }
            private set
            {
                if (_FilterByCompany != value)
                {
                    _FilterByCompany = value;
                    FilterByCompanyComboBox.Enabled = value;
                    OnHasFiltered();
                }
            }
        }

        public bool FilterByTransactionDate
        {
            get { return _FilterByTransactionDate; }
            private set
            {
                if (_FilterByTransactionDate != value)
                {
                    _FilterByTransactionDate = value;
                    pnlTransactionDate.Enabled = value;
                    OnHasFiltered();
                }
            }
        }

        public DateTimeRange RangeDate { get; private set; }
        public DateTimeRange TransactionDate { get; private set; }
        public Supplier Supplier { get; private set; }
        public Branch Branch { get; private set; }
        public Company Company { get; private set; }

        private void CkbxRangeDate_CheckedChanged(object sender, EventArgs e)
        {
            FilterByRangeDate = ckbxRangeDate.Checked;
        }

        private void CkbxSupplier_CheckedChanged(object sender, EventArgs e)
        {
            FilterBySupplier = ckbxSupplier.Checked;
        }

        private async Task GetSupplierListAsync()
        {
            cmbxSupplier.Items.Clear();
            var suppliers = await SupplierManager.GetListAsync();

            if (suppliers != null)
            {
                cmbxSupplier.Items.AddRange(suppliers);
            }
        }

        private async Task GetBranchListAsync()
        {
            FilterByBranchComboBox.Items.Clear();
            var branches = await BranchManager.GetListAsync();

            if (branches != null)
            {
                FilterByBranchComboBox.Items.AddRange(branches);
            }
        }

        private async Task GetCompanyListAsync()
        {
            FilterByCompanyComboBox.Items.Clear();
            var companies = await CompanyManager.GetListAsync();

            if (companies != null)
            {
                FilterByCompanyComboBox.Items.AddRange(companies);
            }
        }

        private async void ChequeReportFilter_Load(object sender, EventArgs e)
        {
            SupplierManager = new SupplierManager();
            BranchManager = new BranchManager();
            CompanyManager = new CompanyManager();

            await GetSupplierListAsync();
            await GetBranchListAsync();
            await GetCompanyListAsync();
            OnHasFiltered();
        }

        private void DtpRangeDate_Start_ValueChanged(object sender, EventArgs e)
        {
            RangeDate = new DateTimeRange(dtpRangeDate_Start.Value, dtpRangeDate_End.Value);
        }

        private void DtpRangeDate_End_ValueChanged(object sender, EventArgs e)
        {
            RangeDate = new DateTimeRange(dtpRangeDate_Start.Value, dtpRangeDate_End.Value);
        }

        private void CmbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier = cmbxSupplier.SelectedItem as Supplier;
        }

        private void OnHasFiltered()
        {
            var filtered = ckbxRangeDate.Checked || ckbxSupplier.Checked || FilterByBranchCheckBox.Checked || FilterByCompanyCheckBox.Checked || FilterByChequeTransactionDateCheckBox.Checked;
            HasFiltered?.Invoke(filtered);
        }

        private void FilterByBranchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterByBranch = FilterByBranchCheckBox.Checked;
        }

        private void FilterByCompanyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterByCompany = FilterByCompanyCheckBox.Checked;
        }

        private void FilterByBranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Branch = FilterByBranchComboBox.SelectedItem as Branch;
        }

        private void FilterByCompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Company = FilterByCompanyComboBox.SelectedItem as Company;
        }

        private void FilterByChequeTransactionDate_CheckedChanged(object sender, EventArgs e)
        {
            FilterByTransactionDate = FilterByChequeTransactionDateCheckBox.Checked;
        }

        private void dtpTransactionDate_Start_ValueChanged(object sender, EventArgs e)
        {
            TransactionDate = new DateTimeRange(dtpTransactionDate_Start.Value, dtpTransactionDate_End.Value);
        }

        private void dtpTransactionDate_End_ValueChanged(object sender, EventArgs e)
        {
            TransactionDate = new DateTimeRange(dtpTransactionDate_Start.Value, dtpTransactionDate_End.Value);
        }
    }
}
