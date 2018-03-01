using System;
using System.Collections.Generic;

namespace Citicon.Data
{
    public class BillingPayment : EntityBase<ulong>
    {
        public BillingPaymentType PaymentType { get; set; }
        public decimal AmountPaid { get; set; }
        public bool VatIncluded { get; set; }
        public decimal? VatLess { get; set; }
        public decimal? Ewt { get; set; }
        public string OrNumber { get; set; }
        public string AckNumber { get; set; }
        public string CrNumber { get; set; }
        public string PrNumber { get; set; }
        public string Bank { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime ChequeDate { get; set; }
        public decimal? TotalVat
        {
            get
            {
                if (VatLess == null || Ewt == null)
                {
                    return null;
                }
                else
                {
                    return (AmountPaid / VatLess) * Ewt;
                }
            }
        }
        public DateTime PaymentDate { get; set; }
        public List<Billing> Billings { get; set; } = new List<Billing>();
    }
}
