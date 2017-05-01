using Citicon.Data;
using System.Collections.Generic;
using System.Linq;

namespace Citicon.Extensions
{
    public static class IEnumerableExtensions
    {
        public static TripReportItemCollection ToTripReportItems(this IEnumerable<Delivery> deliveries)
        {
            if (deliveries.Any())
            {
                var tripReportItems = new TripReportItemCollection();

                foreach (var delivery in deliveries)
                {
                    tripReportItems[delivery.Driver].Add(delivery);
                }

                return tripReportItems;
            }
            else
            {
                return null;
            }
        }
    }
}
