using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class DeliveryRouteManager
    {
        private static Dictionary<long, DeliveryRoute> Dictionary { get; } = new Dictionary<long, DeliveryRoute>();

        public static async Task<DeliveryRoute> GetByIdAsync(long routeId)
        {
            if (routeId > 0)
            {
                if (Dictionary.ContainsKey(routeId))
                {
                    return Dictionary[routeId];
                }
                else
                {
                    using (var process = new GetDeliveryRouteById(routeId))
                    {
                        var route = await process.ExecuteAsync();

                        if (route != null)
                        {
                            Dictionary.Add(routeId, route);
                        }

                        return route;
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<DeliveryRoute> InsertAsync(DeliveryRoute route)
        {
            if (route != null)
            {
                using (var process = new InsertDeliveryRoute(route))
                {
                    route = await process.ExecuteAsync();

                    if (route != null)
                    {
                        Dictionary.Add(route.Id, route);
                    }
                }
            }

            return route;
        }

        public async Task<DeliveryRoute> UpdateAsync(DeliveryRoute route)
        {
            if (route != null)
            {
                using (var process = new UpdateDeliveryRoute(route))
                {
                    route = await process.ExecuteAsync();

                    if (route != null)
                    {
                        Dictionary[route.Id] = route;
                    }
                }
            }

            return route;
        }

        public Task<IEnumerable<DeliveryRoute>> GetListAsync()
        {
            using (var process = new GetDeliveryRouteList())
            {
                return process.ExecuteAsync();
            }
        }
    }
}
