using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public class HolidayTypeManager
    {
        private static Dictionary<ulong, HolidayType> Dictionary { get; } = new Dictionary<ulong, HolidayType>();

        public Task<IEnumerable<HolidayType>> GetListAsync()
        {
            using (var process = new GetHolidayTypeList())
            {
                return process.ExecuteAsync();
            }
        }

        public async Task<HolidayType> GetByIdAsync(ulong holidayTypeId)
        {
            if (holidayTypeId > 0)
            {
                if (Dictionary.ContainsKey(holidayTypeId))
                {
                    return Dictionary[holidayTypeId];
                }
                else
                {
                    using (var process = new GetHolidayTypeById(holidayTypeId))
                    {
                        var holidayType = await process.ExecuteAsync();

                        if (holidayType != null)
                        {
                            Dictionary.Add(holidayTypeId, holidayType);
                        }

                        return holidayType;
                    }
                }
            }
            else
            {
                return null;
            }
        }
    }
}
