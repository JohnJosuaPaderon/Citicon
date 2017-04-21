using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class DeliveryRouteManager
    {
        public Task<IEnumerable<DeliveryRoute>> GetListAsync()
        {
            using (var process = new GetDeliveryRouteList())
            {
                return process.ExecuteAsync();
            }
        }
    }
}
