using System;

namespace Citicon.Data
{
    public class Delivery
    {
        public ulong Id { get; set; }
        public Billing Billing { get; set; }
        public Project Project { get; set; }
        public ProjectDesign ProjectDesign { get; set; }
        public ulong DeliveryReceiptNumber { get; set; }
        public string Load { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Vehicle TransitMixer { get; set; }
        public Employee Driver { get; set; }
        public DateTimeRange PlantTrip { get; set; }
        public decimal Volume { get; set; }
        public decimal CommulativeVolume { get; set; }
        public string Remarks { get; set; }
        public decimal PricePerCubicMeter { get; set; }
        public DateTime PlantLeave { get; set; }
        public DateTime PlantArrive { get; set; }

        public static bool operator ==(Delivery left, Delivery right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(Delivery left, Delivery right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Delivery)
            {
                return (Delivery)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
