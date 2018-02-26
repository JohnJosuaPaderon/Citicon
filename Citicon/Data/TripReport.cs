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
                var tripReports = new TripReport(new DateTimeRange(default(DateTime), default(DateTime)), TripReportMode.All);

                foreach (var delivery in deliveries)
                {
                    var deliveryDate = delivery.DeliveryDate.Date;

                    if (deliveryDate < tripReports.DeliveryDateRange.Begin.Date)
                    {
                        tripReports.DeliveryDateRange.Begin = deliveryDate;
                    }

                    if (deliveryDate > tripReports.DeliveryDateRange.End.Date)
                    {
                        tripReports.DeliveryDateRange.End = deliveryDate;
                    }

                    tripReports
                        .Drivers[delivery.Driver]
                        .TripDates[deliveryDate]
                        .Projects[delivery.Project]
                        .Deliveries.Add(delivery);
                }

                return tripReports;
            }
            else
            {
                return null;
            }
        }

        public static TripReport Extract(DateTimeRange deliveryDateRange, IEnumerable<Delivery> deliveries)
        {
            if (deliveryDateRange != null && deliveries != null && deliveries.Any())
            {
                var tripReports = new TripReport(deliveryDateRange, TripReportMode.All);

                foreach (var delivery in deliveries)
                {
                    tripReports
                        .Drivers[delivery.Driver]
                        .TripDates[delivery.DeliveryDate.Date]
                        .Projects[delivery.Project]
                        .Deliveries.Add(delivery);
                }

                return tripReports;
            }
            else
            {
                return null;
            }
        }

        public static TripReport ExtractDriver(DateTimeRange deliveryDateRange, Employee driver, IEnumerable<Delivery> deliveries)
        {
            if (deliveryDateRange != null && driver != null && deliveries != null && deliveries.Any())
            {
                var tripReports = new TripReport(deliveryDateRange, TripReportMode.Driver);

                foreach (var delivery in deliveries)
                {
                    if (delivery.Driver == driver)
                    {
                        tripReports
                        .Drivers[driver]
                        .TripDates[delivery.DeliveryDate.Date]
                        .Projects[delivery.Project]
                        .Deliveries.Add(delivery);
                    }
                }

                return tripReports;
            }
            else
            {
                return null;
            }
        }

        private TripReport(DateTimeRange deliveryDateRange, TripReportMode mode)
        {
            DeliveryDateRange = deliveryDateRange ?? throw new ArgumentNullException(nameof(deliveryDateRange));
            Drivers = new TripReportDriverCollection(this);
            Mode = mode;
        }

        public TripReportMode Mode { get; }
        public DateTimeRange DeliveryDateRange { get; }
        public TripReportDriverCollection Drivers { get; }
    }
}
