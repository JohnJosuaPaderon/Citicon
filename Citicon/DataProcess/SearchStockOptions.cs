using Citicon.Data;

namespace Citicon.DataProcess
{
    public struct SearchStockOptions
    {
        public bool SearchByItem { get; set; }
        public Item Item { get; set; }
        public bool SearchBySupplier { get; set; }
        public Supplier Supplier { get; set; }
        public bool SearchByBranch { get; set; }
        public Branch Branch { get; set; }
        public bool SearchByDeliveryDateRange { get; set; }
        public DateTimeRange DeliveryDateRange { get; set; }
        public bool SearchBySiNumber { get; set; }
        public string SiNumber { get; set; }
        public bool SearchByDrNumber { get; set; }
        public string DrNumber { get; set; }
    }
}
