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

        public async Task<TransitMixer> InsertAsync(TransitMixer transitMixer)
        {
            if (transitMixer != null)
            {
                using (var process = new InsertTransitMixer(transitMixer))
                {
                    transitMixer = await process.ExecuteAsync();
                }
            }

            return transitMixer;
        }

        public async Task<TransitMixer> UpdateAsync(TransitMixer transitMixer)
        {
            if (transitMixer != null)
            {
                using (var process = new UpdateTransitMixer(transitMixer))
                {
                    transitMixer = await process.ExecuteAsync();
                }
            }

            return transitMixer;
        }

        public async Task<TransitMixer> DeleteAsync(TransitMixer transitMixer)
        {
            if (transitMixer != null)
            {
                using (var process = new DeleteTransitMixer(transitMixer))
                {
                    transitMixer = await process.ExecuteAsync();
                }
            }

            return transitMixer;
        }
    }
}
