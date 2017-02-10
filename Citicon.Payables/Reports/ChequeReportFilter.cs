using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Data;
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
            SupplierManager = new SupplierManager();
        }

        private SupplierManager SupplierManager;
        public Action<bool> HasFiltered { get; set; }

        public bool FilterByRangeDate { get; private set; }
        public bool FilterBySupplier { get; private set; }
        public DateTimeRange RangeDate { get; private set; }
        public Supplier Supplier { get; private set; }

        private void ckbxRangeDate_CheckedChanged(object sender, EventArgs e)
        {
            pnlRangeDate.Enabled = ckbxRangeDate.Checked;
            FilterByRangeDate = ckbxRangeDate.Checked;
            ChangeHasFiltered();
        }

        private void ckbxSupplier_CheckedChanged(object sender, EventArgs e)
        {
            cmbxSupplier.Enabled = ckbxSupplier.Checked;
            FilterBySupplier = ckbxSupplier.Checked;
            ChangeHasFiltered();
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

        private async void ChequeReportFilter_Load(object sender, EventArgs e)
        {
            await GetSupplierListAsync();
            ChangeHasFiltered();
        }

        private void dtpRangeDate_Start_ValueChanged(object sender, EventArgs e)
        {
            RangeDate = new DateTimeRange(dtpRangeDate_Start.Value, dtpRangeDate_End.Value);
        }

        private void dtpRangeDate_End_ValueChanged(object sender, EventArgs e)
        {
            RangeDate = new DateTimeRange(dtpRangeDate_Start.Value, dtpRangeDate_End.Value);
        }

        private void cmbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier = (Supplier)cmbxSupplier.SelectedItem;
        }

        private void ChangeHasFiltered()
        {
            var filtered = ckbxRangeDate.Checked || ckbxSupplier.Checked;
            HasFiltered?.Invoke(filtered);
        }
    }
}
