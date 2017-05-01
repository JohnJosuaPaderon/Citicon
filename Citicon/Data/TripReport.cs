using System;
using System.Collections.Generic;
using System.Linq;

namespace Citicon.Data
{
    public class TripReport
    {
        public static TripReport Extract(IEnumerable<Delivery> deliveries)
        {
            if (deliveries != null && deliveries.Any())
            {
                var tripReports = new TripReport(new DateTimeRange(default(DateTime), default(DateTime)));

                foreach (var delivery in deliveries)
                {
                    var deliveryDate = delivery.DeliveryDate.Date;

                    if (deliveryDate < tripReports.DeliveryDateRange.Start.Date)
                    {
                        tripReports.DeliveryDateRange.Start = deliveryDate;
                    }

                    if (deliveryDate > tripReports.DeliveryDateRange.End.Date)
                    {
                        tripReports.DeliveryDateRange.End = deliveryDate;
                    }

                    tripReports
                        .Drivers[delivery.Driver]
                        .TripDates[deliveryDate]
                        .Clients[delivery.Project.Client]
                        .Routes[delivery.Route]
                        .Deliveries.Add(delivery);
                }

                return tripReports;
            }
            else
            {
                return null;
            }
        }

        private TripReport(DateTimeRange deliveryDateRange)
        {
            DeliveryDateRange = deliveryDateRange ?? throw new ArgumentNullException(nameof(deliveryDateRange));
            Drivers = new TripReportDriverCollection(this);
        }

        public DateTimeRange DeliveryDateRange { get; }
        public TripReportDriverCollection Drivers { get; }
    }
}
