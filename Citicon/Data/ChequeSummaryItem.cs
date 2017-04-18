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
        public Company Company { get; set; }
        public DateTime TransactionDate { get; set; }

        public static bool operator ==(ChequeSummaryItem left, ChequeSummaryItem right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.ChequeNumbber == right.ChequeNumbber;
        }

        public static bool operator !=(ChequeSummaryItem left, ChequeSummaryItem right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is ChequeSummaryItem)
            {
                return (ChequeSummaryItem)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ChequeNumbber.GetHashCode();
        }

        public override string ToString()
        {
            return ChequeNumbber;
        }
    }
}
