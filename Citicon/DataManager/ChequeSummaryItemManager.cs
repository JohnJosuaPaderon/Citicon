using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class ChequeSummaryItemManager
    {
        public async Task<IEnumerable<ChequeSummaryItem>> GetFilterIEnumerableAsync(bool filterByDateRange, DateTimeRange dateRange, bool filterBySupplier, Supplier supplier)
        {
            var process = new GetChequeSummaryItemIEnumerable(filterByDateRange, dateRange, filterBySupplier, supplier);
            return await process.ExecuteAsync();
        }
    }
}
