using Citicon.Data;

namespace Citicon.DataProcess
{
    public sealed class GetFilteredOutgoingStockListOption
    {
        public GetFilteredOutgoingStockListOption()
        {
            TransactionDateRange = new DateTimeRange();
        }

        public bool FilterByItem { get; set; }
        public Item Item { get; set; }
        public bool FilterByBranch { get; set; }
        public Branch Branch { get; set; }
        public bool FilterByCompany { get; set; }
        public Company Company { get; set; }
        public bool FilterByVehicle { get; set; }
        public Vehicle Vehicle { get; set; }
        public bool FilterByTransactionDateRange { get; set; }
        public DateTimeRange TransactionDateRange { get; }
    }
}
