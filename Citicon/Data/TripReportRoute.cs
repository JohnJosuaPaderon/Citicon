using System;

namespace Citicon.Data
{
    public class TripReportRoute
    {
        public TripReportRoute(DeliveryRoute route)
        {
            Route = route ?? throw new ArgumentNullException(nameof(route));
            Deliveries = new TripReportDeliveryCollection(this);
        }

        public DeliveryRoute Route { get; }
        public TripReportDeliveryCollection Deliveries { get; }

        public static bool operator ==(TripReportRoute left, TripReportRoute right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Route == right.Route;
        }

        public static bool operator !=(TripReportRoute left, TripReportRoute right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is TripReportRoute)
            {
                return (TripReportRoute)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Route.GetHashCode();
        }
    }
}
