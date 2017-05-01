using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public class TripReport
    {
        public TripReport(DateTimeRange deliveryDateRange)
        {
            DeliveryDateRange = deliveryDateRange ?? throw new ArgumentNullException(nameof(deliveryDateRange));
            Drivers = new TripReportDriverCollection(this);
        }

        public DateTimeRange DeliveryDateRange { get; }
        public TripReportDriverCollection Drivers { get; }
    }
}
