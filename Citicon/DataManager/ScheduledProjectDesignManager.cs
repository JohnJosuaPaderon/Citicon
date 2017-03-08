using Citicon.Data;
using Citicon.DataProcess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class ScheduledProjectDesignManager
    {
        public async Task<ScheduledProjectDesign> InsertAsync(ScheduledProjectDesign scheduledDesign)
        {
            if (scheduledDesign != null)
            {
                using (var process = new InsertScheduledProjectDesign(scheduledDesign))
                {
                    scheduledDesign = await process.ExecuteAsync();
                }
            }

            return scheduledDesign;
        }

        public async Task<List<ScheduledProjectDesign>> InsertListAsync(List<ScheduledProjectDesign> scheduledDesigns)
        {
            if (scheduledDesigns != null && scheduledDesigns.Count > 0)
            {
                using (var process = new InsertScheduledProjectDesignList(scheduledDesigns))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> ExistsAsync(ScheduledProjectDesign scheduledDesign)
        {
            if (scheduledDesign != null)
            {
                using (var process = new ScheduledProjectDesignExists(scheduledDesign))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return false;
            }
        }

        public async Task<IEnumerable<ScheduledProjectDesign>> GetListAsync(DateTime scheduledDate)
        {
            if (scheduledDate.Date != default(DateTime).Date)
            {
                using (var process = new GetScheduledProjectDesignList(scheduledDate))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }
    }
}
