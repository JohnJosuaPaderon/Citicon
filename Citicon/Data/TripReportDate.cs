using System;

namespace Citicon.Data
{
    public class TripReportDate
    {
        public TripReportDate(DateTime deliveryDate)
        {
            DeliveryDate = deliveryDate.Date;
            Projects = new TripReportProjectCollection(this);
        }

        public DateTime DeliveryDate { get; }
        public TripReportProjectCollection Projects { get; }

        public static bool operator ==(TripReportDate left, TripReportDate right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.DeliveryDate.Date == right.DeliveryDate.Date;
        }

        public static bool operator !=(TripReportDate left, TripReportDate right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is TripReportDate)
            {
                return (TripReportDate)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return DeliveryDate.Date.GetHashCode();
        }
    }
}
