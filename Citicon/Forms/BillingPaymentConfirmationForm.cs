using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class BillingPaymentConfirmationForm : Form
    {
        private IEnumerable<Billing> Billings;

        public BillingPaymentConfirmationForm(IEnumerable<Billing> billings)
        {
            Billings = billings;
            InitializeComponent();
        }

        private void BillingPaymentConfirmationForm_Load(object sender, EventArgs e)
        {
            DisplayBillings();
        }

        private void DisplayBillings()
        {
            dgvBillings.Rows.Clear();
            if (Billings != null)
            {
                decimal totalAmountToBePaid = 0;
                var rows = new List<DataGridViewRow>();
                foreach (Billing billing in Billings)
                {
                    totalAmountToBePaid = decimal.Add(totalAmountToBePaid, billing.SubTotal);
                    var row = new DataGridViewRow
                    {
                        Height = 30
                    };
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = billing.SiNumber });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = billing });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = billing.AmountDue });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = billing.AmountPaid });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = billing.SubTotal });
                    rows.Add(row);
                }
                dgvBillings.Rows.AddRange(rows.ToArray());
                nudTotalAmountToBePaid.Value = totalAmountToBePaid;
                gbxPaymentAllocation.Enabled = false;
            }
        }

        private void ckbxVatIncluded_CheckedChanged(object sender, EventArgs e)
        {
            pnlVatIncluded.Enabled = ckbxVatIncluded.Checked;
            CalculateTotalVat();
        }

        private void dgvBillings_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }

        private void rbtnPaymentAllocation_PaymentMode_Partial_CheckedChanged(object sender, EventArgs e)
        {
            nudPaymentAllocation_AllocatedAmount.Enabled = rbtnPaymentAllocation_PaymentMode_Partial.Checked;
        }

        private void dgvBillings_SelectionChanged(object sender, EventArgs e)
        {
            EnablePaymentAllocationControls();
            UpdateForFullPayment();
        }

        private void EnablePaymentAllocationControls()
        {
            if (dgvBillings.SelectedRows.Count == 1)
            {
                var row = dgvBillings.SelectedRows[0];
                var billing = (Billing)row.Cells[colBilling.Name].Value;
                var amountDue = (decimal)(row.Cells[colBilling_AmountDue.Name].Value ?? 0M);
                var amountPaid = (decimal)(row.Cells[colBilling_AmountPaid.Name].Value ?? 0M);
                var subTotal = (decimal)(row.Cells[colBilling_SubTotal.Name].Value ?? 0M);
                var allocatedAmount = (decimal)(row.Cells[colBilling_AllocatedAmount.Name].Value ?? 0M);
                tbxPaymentAllocation_BillingNumber.Text = string.Empty;
                gbxPaymentAllocation.Enabled = (billing.SubTotal != 0 && nudAmountPaid.Value > 0);

                rbtnPaymentAllocation_PaymentMode_Full.Checked = subTotal == allocatedAmount;
                rbtnPaymentAllocation_PaymentMode_Partial.Checked = subTotal != allocatedAmount;
                if (billing.SubTotal != 0)
                {
                    tbxPaymentAllocation_BillingNumber.Text = billing.BillingNo;
                    nudPaymentAllocation_AllocatedAmount.Maximum = billing.SubTotal;
                    nudPaymentAllocation_AllocatedAmount.Value = amountPaid - billing.AmountPaid;
                }
            }
        }

        private void nudPaymentAllocation_AllocatedAmount_Leave(object sender, EventArgs e)
        {

        }

        private void btnPaymentAllocation_Done_Click(object sender, EventArgs e)
        {
            if (dgvBillings.SelectedRows.Count == 1)
            {
                var row = dgvBillings.SelectedRows[0];
                row.Cells[colBilling_AllocatedAmount.Name].Value = nudPaymentAllocation_AllocatedAmount.Value;
                CalculateRemainingAmount();
            }
        }

        private void CalculateRemainingAmount()
        {
            decimal totalAllocatedAmount = 0;
            foreach (DataGridViewRow row in dgvBillings.Rows)
            {
                totalAllocatedAmount = decimal.Add(totalAllocatedAmount, (decimal)(row.Cells[colBilling_AllocatedAmount.Name].Value ?? 0M));
            }
            nudRemaining.Value = decimal.Subtract(nudAmountPaid.Value, totalAllocatedAmount);
        }

        private void nudAmountPaid_ValueChanged(object sender, EventArgs e)
        {
            IncrementRemainingAmount(nudAmountPaid.Value);
            EnablePaymentAllocationControls();
            UpdateForFullPayment();
            CalculateRemainingAmount();
        }

        private void IncrementRemainingAmount(decimal value)
        {

        }

        private void rbtnPaymentAllocation_PaymentMode_Full_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForFullPayment();
        }

        private void UpdateForFullPayment()
        {
            if (rbtnPaymentAllocation_PaymentMode_Full.Checked)
            {
                if (dgvBillings.SelectedRows.Count == 1)
                {
                    var row = dgvBillings.SelectedRows[0];
                    var billing = (Billing)row.Cells[colBilling.Name].Value;
                    nudPaymentAllocation_AllocatedAmount.Maximum = billing.SubTotal;
                    nudPaymentAllocation_AllocatedAmount.Value = billing.SubTotal;
                }
            }
        }

        private void nudRemaining_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvBillings_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPayCheckedBillings_Click(object sender, EventArgs e)
        {
            if (nudRemaining.Value < 0)
            {
                MessageBox.Show("Your allocated amount is greater than you entered amount paid.");
            }
            else
            {
                SaveBillingPayment();
            }
        }

        private void SaveBillingPayment()
        {
            BillingPayment billingPayment = new BillingPayment();
            bool vatIncluded = ckbxVatIncluded.Checked;
            foreach (DataGridViewRow row in dgvBillings.Rows)
            {
                var billing = (Billing)row.Cells[colBilling.Name].Value;
                var allocatedAmount = (decimal)(row.Cells[colBilling_AllocatedAmount.Name].Value ?? 0M);
                billing.AmountPaid = (billing.AmountPaid + allocatedAmount);
                billingPayment.Billings.Add(billing);
            }
            billingPayment.AmountPaid = nudAmountPaid.Value;
            billingPayment.Ewt = vatIncluded ? nudVatIncluded_Ewt.Value : new decimal?();
            billingPayment.PaymentType = rbtnPaymentType_Cash.Checked ? BillingPaymentType.Cash : BillingPaymentType.Cheque;
            billingPayment.VatIncluded = vatIncluded;
            billingPayment.VatLess = vatIncluded ? nudVatIncluded_VatLess.Value : new decimal?();

            var task = BillingPaymentManager.SavePaymentAsync(billingPayment);
            task.ContinueWith(DisplaySavePaymentResult);
        }

        private void DisplaySavePaymentResult(Task task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Payment Saved!");
                    Close();
                }));
            }
            else
            {
                MessageBox.Show("Failed to save Payment");
            }
        }

        private void nudVatIncluded_VatLess_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalVat();
        }

        private void CalculateTotalVat()
        {
            if (ckbxVatIncluded.Checked)
            {
                var totalAmountTobePaid = nudTotalAmountToBePaid.Value;
                var vatLess = nudVatIncluded_VatLess.Value;
                var ewt = nudVatIncluded_Ewt.Value;

                if (vatLess == 0)
                {
                    vatLess = 1;
                }

                if (ewt == 0)
                {
                    ewt = 1;
                }

                var totalVat = (totalAmountTobePaid / vatLess) * ewt;
                nudVatIncluded_TotalVat.Maximum = totalVat;
                nudVatIncluded_TotalVat.Value = totalVat;
            }
            else
            {
                nudVatIncluded_Ewt.Value = 0;
                nudVatIncluded_VatLess.Value = 0;
                nudVatIncluded_TotalVat.Value = 0;
            }
        }

        private void nudVatIncluded_Ewt_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalVat();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudTotalAmountToBePaid_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalVat();
            CalculateAmountDue();
        }

        private void nudVatIncluded_TotalVat_ValueChanged(object sender, EventArgs e)
        {
            CalculateAmountDue();
        }

        private void CalculateAmountDue()
        {
            var amountToBePaid = nudTotalAmountToBePaid.Value;
            var totalVat = nudVatIncluded_TotalVat.Value;

            nudAmountDue.Value = amountToBePaid - totalVat;
        }
    }
}