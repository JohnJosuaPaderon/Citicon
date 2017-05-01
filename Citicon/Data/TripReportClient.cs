using System;

namespace Citicon.Data
{
    public class TripReportClient
    {
        public TripReportClient(Client client)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
            Routes = new TripReportRouteCollection(this);
        }

        public Client Client { get; }
        public TripReportRouteCollection Routes { get; }

        public static bool operator ==(TripReportClient left, TripReportClient right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Client == right.Client;
        }

        public static bool operator !=(TripReportClient left, TripReportClient right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is TripReportClient)
            {
                return (TripReportClient)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Client.GetHashCode();
        }
    }
}
