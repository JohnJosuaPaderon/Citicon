using Citicon.Data;
using Citicon.DataProcess;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class TripReportManager
    {
        public static async Task ExportDriverTripReportAsync(TripReport tripReport)
        {
            if (tripReport != null)
            {
                using (var process = new ExportDriverTripReport(tripReport))
                {
                    await process.ExecuteAsync();
                }
            }
        }

        public static async Task ExportAllDriverTripReportAsync(TripReport tripReport)
        {
            if (tripReport != null)
            {
                using (var process = new ExportAllDriverTripReport(tripReport))
                {
                    await process.ExecuteAsync();
                }
            }
        }
    }
}
