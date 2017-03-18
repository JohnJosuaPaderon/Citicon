using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class ChequeSummaryItemManager
    {
        public async Task<IEnumerable<ChequeSummaryItem>> GetFilterIEnumerableAsync(bool filterByDateRange, DateTimeRange dateRange, bool filterBySupplier, Supplier supplier, bool filterByBranch, Branch branch, bool filterByCompany, Company company)
        {
            var process = new GetChequeSummaryItemIEnumerable(filterByDateRange, dateRange, filterBySupplier, supplier, filterByBranch, branch, filterByCompany, company);
            return await process.ExecuteAsync();
        }
    }
}
