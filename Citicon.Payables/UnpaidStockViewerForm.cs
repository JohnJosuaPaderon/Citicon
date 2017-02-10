using Citicon.Inventory.Data;
using System;
using System.Windows.Forms;

namespace Citicon.Payables
{
    public partial class UnpaidStockViewerForm : Form
    {
        private Stock currentStock;
        public UnpaidStockViewerForm(Stock unpaidStock)
        {
            InitializeComponent();
            currentStock = unpaidStock;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
            
        private void UnpaidStockViewerForm_Load(object sender, EventArgs e)
        {
            tbxAddedStockValue.Text = currentStock.AddedStockValue.ToString("#,##0");
            tbxBranch.Text = currentStock.Branch.Description;
            tbxCompany.Text = currentStock.Company.Description;
            tbxDeliveryDate.Text = currentStock.DeliveryDate.ToString("MMMM dd, yyyy");
            tbxDueDate.Text = currentStock.DueDate.ToString("MMMM dd, yyyy");
            tbxItemCode.Text = currentStock.Item.Code;
            tbxItemDescription.Text = currentStock.Item.Description;
            tbxLastStockValue.Text = currentStock.LastStockValue.ToString("#,##0");
            tbxMrisNumber.Text = currentStock.MrisNumber;
            tbxPaymentTerm.Text = currentStock.PaymentTerm.Description;
            tbxSupplier.Text = currentStock.Supplier.Description;
            tbxUnitPrice.Text = currentStock.UnitPrice.ToString("#,##0.00");
            tbxVehicle.Text = currentStock.Vehicle.ToString();
        }
    }
}
