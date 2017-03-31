using System;

namespace Citicon.Data
{
    public sealed class Transaction
    {
        public ulong Id { get; set; }
        public Item Item { get; set; }
        public decimal LastStockValue { get; set; }
        public decimal RemovedStockValue { get; set; }
        public string Purpose { get; set; }
        public string RequestedBy { get; set; }
        public Branch Branch { get; set; }
        public Company Company { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ReleasedBy { get; set; }
        public Vehicle Truck { get; set; }
        public uint SeriesNumber { get; set; }

        public static bool operator ==(Transaction left, Transaction right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Transaction left, Transaction right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Transaction)
            {
                return (Transaction)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Item?.ToString();
        }
    }
}
