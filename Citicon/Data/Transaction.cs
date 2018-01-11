using System;

namespace Citicon.Data
{
    public sealed class Transaction : EntityBase<ulong>
    {
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
        public string IssuanceSlipNumber { get; set; }
        public decimal? LatestPrice { get; set; }
        public DateTime? LatestPriceDate { get; set; }
        
        public override string ToString()
        {
            return Item?.ToString();
        }
    }
}
