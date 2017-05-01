using System;

namespace Citicon.Data
{
    public class TripReportDriver
    {
        public TripReportDriver(Employee driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            TripDates = new TripReportDateCollection(this);
        }

        public Employee Driver { get; }
        public TripReportDateCollection TripDates { get; }

        public static bool operator ==(TripReportDriver left, TripReportDriver right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Driver == right.Driver;
        }

        public static bool operator !=(TripReportDriver left, TripReportDriver right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is TripReportDriver)
            {
                return (TripReportDriver)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Driver.GetHashCode();
        }
    }
}
