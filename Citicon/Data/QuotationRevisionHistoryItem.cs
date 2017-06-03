using System;

namespace Citicon.Data
{
    public class QuotationRevisionHistoryItem
    {
        public QuotationRevisionHistoryItem(Quotation quotation)
        {
            Quotation = quotation ?? throw new ArgumentNullException(nameof(quotation));
            RevisionNumber = quotation.RevisionNumber + 1;
        }

        public Quotation Quotation { get; }
        public uint RevisionNumber { get; }


        public static bool operator ==(QuotationRevisionHistoryItem left, QuotationRevisionHistoryItem right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Quotation == right.Quotation && left.RevisionNumber == right.RevisionNumber;
        }

        public static bool operator !=(QuotationRevisionHistoryItem left, QuotationRevisionHistoryItem right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is QuotationRevisionHistoryItem)
            {
                return (QuotationRevisionHistoryItem)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Quotation.GetHashCode() ^ RevisionNumber.GetHashCode();
        }

        public override string ToString()
        {
            return RevisionNumber.ToString();
        }
    }
}
