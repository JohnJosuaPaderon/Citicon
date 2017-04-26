using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class TransitMixerManager
    {
        private static Dictionary<ulong, TransitMixer> Dictionary { get; } = new Dictionary<ulong, TransitMixer>();

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

        public async Task<TransitMixer> GetByIdAsync(ulong transitMixerId)
        {
            if (transitMixerId > 0)
            {
                if (Dictionary.ContainsKey(transitMixerId))
                {
                    return Dictionary[transitMixerId];
                }
                else
                {
                    using (var process = new GetTransitMixerById(transitMixerId))
                    {
                        var transitMixer = await process.ExecuteAsync();

                        if (transitMixer != null)
                        {
                            Dictionary.Add(transitMixerId, transitMixer);
                        }

                        return transitMixer;
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
