using Citicon.Data;
using Citicon.Payables.Data;
using System;

namespace Citicon.Inventory.Data
{
    public sealed class Stock
    {
        public ulong Id { get; set; }
        public Item Item { get; set; }
        public Expense Expense { get; set; }
        public DateTime DeliveryDate { get; set; }
        public uint SiNumber { get; set; }
        public uint DrNumber { get; set; }
        public string MrisNumber { get; set; }
        public decimal LastStockValue { get; set; }
        public decimal AddedStockValue { get; set; }
        public decimal UnitPrice { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public DateTime DueDate { get; set; }
        public Vehicle Vehicle { get; set; }
        public string AcceptedBy { get; set; }
        public Branch Branch { get; set; }
        public Company Company { get; set; }
        public Supplier Supplier { get; set; }
        public bool Paid { get; set; }
        public string Remarks { get; set; }
        public string MeasurementDescription { get; set; }
        public bool IncludeWithHoldingTax { get; set; }
        public decimal? WithHoldingTax { get; set; }
        public Client CementSuppliedClient { get; set; }
        public Project[] CementSuppliedProjects { get; set; }

        public static bool operator ==(Stock left, Stock right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Stock left, Stock right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Stock)
            {
                return (Stock)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override string ToString()
        {
            return Expense != null ? Expense.Description : Item?.ToString() ?? string.Empty;
        }
    }
}
