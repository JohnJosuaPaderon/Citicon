using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class TimeLogTypeManager
    {
        static TimeLogTypeManager()
        {
            TimeLogTypeDict = new Dictionary<ulong, TimeLogType>();
        }

        private static Dictionary<ulong, TimeLogType> TimeLogTypeDict { get; }

        public async Task<TimeLogType> GetByIdAsync(ulong id)
        {
            if (TimeLogTypeDict.ContainsKey(id))
            {
                return TimeLogTypeDict[id];
            }
            else
            {
                var process = new GetTimeLogTypeById(id);
                var timeLogType = await process.ExecuteAsync();
                TimeLogTypeDict.Add(id, timeLogType);

                return timeLogType;
            }
        }
    }
}
