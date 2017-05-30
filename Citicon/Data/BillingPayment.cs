﻿using System;
using System.Collections.Generic;

namespace Citicon.Data
{
    public class BillingPayment
    {
        public ulong Id { get; set; }
        public BillingPaymentType PaymentType { get; set; }
        public decimal AmountPaid { get; set; }
        public bool VatIncluded { get; set; }
        public decimal? VatLess { get; set; }
        public decimal? Ewt { get; set; }
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
