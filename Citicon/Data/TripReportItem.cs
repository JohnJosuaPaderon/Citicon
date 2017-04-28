using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public class TripReportItem
    {
        public TripReportItem(Employee driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Deliveries = new TripReportItemDeliveryCollection(this);
        }

        public Employee Driver { get; }
        public DateTime DeliveryDate { get; }
        public TripReportItemDeliveryCollection Deliveries { get; }

    }
}
