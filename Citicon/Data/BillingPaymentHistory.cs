using System;

namespace Citicon.Data
{
    public sealed class BillingPaymentHistory : EntityBase<ulong>
    {
        public BillingPaymentHistory(Billing billing, BillingPayment payment)
        {
            Billing = billing ?? throw new ArgumentNullException(nameof(billing));
            Payment = payment ?? throw new ArgumentNullException(nameof(payment));
        }

        public Billing Billing { get; }
        public BillingPayment Payment { get; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
