using System;

namespace Citicon.Data
{
    public sealed class ChequeSummaryItem
    {
        public string ChequeNumbber { get; set; }
        public DateTime ChequeDate { get; set; }
        public Supplier Supplier { get; set; }
        public decimal TotalAmount { get; set; }
        public BankAccount BankAccount { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
