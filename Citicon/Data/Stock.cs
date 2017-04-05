using System;
using System.Text;

namespace Citicon.Data
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
        public string SIDR
        {
            get
            {
                var sidrBuilder = new StringBuilder();

                var hasSi = SiNumber > 0;
                var hasDr = DrNumber > 0;

                if (hasSi)
                {
                    sidrBuilder.AppendFormat("SI={0}", SiNumber);

                    if (hasDr)
                    {
                        sidrBuilder.Append(",");
                    }
                }

                if (hasDr)
                {
                    sidrBuilder.AppendFormat("DR={0}", DrNumber);
                }

                return sidrBuilder.ToString();
            }
        }
        public string ReportDescription
        {
            get
            {
                if (Item != null)
                {
                    if (Item.MeasurementUnit == MeasurementUnit.CubicMeter)
                    {
                        return MeasurementDescription;
                    }
                    else
                    {
                        return Item.Description;
                    } 
                }
                else
                {
                    return null;
                }
            }
        }
        public decimal TotalAmount
        {
            get { return AddedStockValue * UnitPrice; }
        }
        public decimal TotalVAT
        {
            get
            {
                if (IncludeWithHoldingTax && WithHoldingTax != 0)
                {
                    return (TotalAmount / WithHoldingTax ?? 1) * 0.12M;
                }
                else
                {
                    return 0;
                }
            }
        }

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
