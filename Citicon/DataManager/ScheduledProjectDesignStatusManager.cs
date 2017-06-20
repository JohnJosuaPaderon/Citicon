using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class ScheduledProjectDesignStatusManager
    {
        private static IEnumerable<ScheduledProjectDesignStatus> Source { get; set; }

        public static async Task<IEnumerable<ScheduledProjectDesignStatus>> GetListAsync()
        {
            if (Source == null || !Source.Any())
            {
                using (var process = new GetScheduledProjectDesignStatusList())
                {
                    Source = await process.ExecuteAsync();
                }
            }

            return Source;
        }
    }
}
