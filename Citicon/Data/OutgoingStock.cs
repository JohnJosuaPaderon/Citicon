using System;

namespace Citicon.Data
{
    public class OutgoingStock : EntityBase<ulong>
    {
        public string IssuanceSlipNumber { get; set; }
        public Item Item { get; set; }
        public decimal Quantity { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
        public decimal UnitCost { get; set; }
        public Supplier Supplier { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
