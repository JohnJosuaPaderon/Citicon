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

        public async Task<decimal> GetMaximumVolumeByProjectDesignAndDeliveryDateAsync(ProjectDesign projectDesign, DateTime deliveryDate)
        {
            if (projectDesign != null)
            {
                using (var process = new GetMaximumScheduledVolumeByProjectDesignAndDeliveryDate(projectDesign, deliveryDate))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return 0;
            }
        }

        public async Task<IEnumerable<ScheduledProjectDesign>> GetListAsync(DateTime scheduledDate, ScheduledProjectDesignStatus status)
        {
            if (scheduledDate.Date != default(DateTime).Date && status != null)
            {
                using (var process = new GetScheduledProjectDesignList(scheduledDate, status))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public Task<IEnumerable<ScheduledProjectDesign>> GetListByStatusAsync(ScheduledProjectDesignStatus status)
        {
            if (status != null)
            {
                using (var process = new GetScheduledProjectDesignListByStatus(status))
                {
                    return process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<ScheduledProjectDesign> UpdateAsync(ScheduledProjectDesign scheduledProjectDesign)
        {
            if (scheduledProjectDesign != null)
            {
                using (var process = new UpdateScheduledProjectDesign(scheduledProjectDesign))
                {
                    scheduledProjectDesign = await process.ExecuteAsync();
                }
            }

            return scheduledProjectDesign;
        }

        public async Task<ScheduledProjectDesign> DeleteAsync(ScheduledProjectDesign scheduledProjectDesign)
        {
            if (scheduledProjectDesign != null)
            {
                using (var process = new DeleteScheduledProjectDesign(scheduledProjectDesign))
                {
                    scheduledProjectDesign = await process.ExecuteAsync();
                }
            }

            return scheduledProjectDesign;
        }
    }
}
