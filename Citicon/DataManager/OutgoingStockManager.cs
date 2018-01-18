using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class OutgoingStockManager
    {
        public static async Task<IEnumerable<OutgoingStock>> GetFilteredListAsync(GetFilteredOutgoingStockListOption option)
        {
            using (var process = new GetFilteredOutgoingStockList(option))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task ExportReportAsync(IEnumerable<OutgoingStock> outgoingStocks)
        {
            if (outgoingStocks != null && outgoingStocks.Any())
            {
                using (var process = new ExportOutgoingStockReport(outgoingStocks))
                {
                    await process.ExecuteAsync();
                }
            }
        }
    }
}
