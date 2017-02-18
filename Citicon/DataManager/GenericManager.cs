using Citicon.DataProcess;
using System;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class GenericManager
    {
        public async Task<DateTime> GetCurrentDateAsync()
        {
            var process = new GetCurrentDate();
            return await process.ExecuteAsync();
        }
    }
}
