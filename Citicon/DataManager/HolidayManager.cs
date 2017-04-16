using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public class HolidayManager
    {
        private static Dictionary<ulong, Holiday> Dictionary { get; } = new Dictionary<ulong, Holiday>();

        public Task<IEnumerable<Holiday>> GetHolidayListAsync(HolidaySearchFilter searchFilter)
        {
            using (var process = new GetHolidayList(searchFilter))
            {
                return process.ExecuteAsync();
            }
        }

        public Task<Holiday> InsertAsync(Holiday holiday)
        {
            if (holiday != null)
            {
                using (var process = new InsertHoliday(holiday))
                {
                    return process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public Task<Holiday> DeleteAsync(Holiday holiday)
        {
            if (holiday != null)
            {
                using (var process = new DeleteHoliday(holiday))
                {
                    return process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public Task<Holiday> UpdateAsync(Holiday holiday)
        {
            if (holiday != null)
            {
                using (var process = new UpdateHoliday(holiday))
                {
                    return process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }
    }
}
