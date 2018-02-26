using System;
using System.Collections.Generic;

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

        public decimal ShopRatePay
        {
            get
            {
                return Driver.ShopRate * TripDates.Count;
            }
        }

        public decimal GrossPay
        {
            get
            {
                return TotalAmount + ShopRatePay;
            }
        }

        public int TotalTrips
        {
            get
            {
                var result = 0;

                foreach (var tripDate in TripDates)
                {
                    foreach (var tripProject in tripDate.Projects)
                    {
                        result += tripProject.Deliveries.TripCount;
                    }
                }

                return result;
            }
        }

        public decimal TotalAmount
        {
            get
            {
                var result = 0M;

                foreach (var tripDate in TripDates)
                {
                    foreach (var tripProject in tripDate.Projects)
                    {
                        result += tripProject.Deliveries.TotalAmount;
                    }
                }

                return result;
            }
        }

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
