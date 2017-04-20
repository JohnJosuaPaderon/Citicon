using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class TransitMixerManager
    {
        public Task<IEnumerable<TransitMixer>> GetListAsync()
        {
            using (var process = new GetTransitMixerList())
            {
                return process.ExecuteAsync();
            }
        }
    }
}
