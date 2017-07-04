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
        public TransitMixer TransitMixer { get; set; }
        public Employee Driver { get; set; }
        public decimal Volume { get; set; }
        public decimal CommulativeVolume { get; set; }
        public string Remarks { get; set; }
        public decimal PricePerCubicMeter { get; set; }
        public DateTime? PlantLeave { get; set; }
        public DateTime? PlantArrive { get; set; }
        public DateTime? ProjectArrive { get; set; }
        public DateTime? StartUnloading { get; set; }
        public DateTime? FinishedUnloading { get; set; }
        public DateTime? EstimatedStay { get; set; }
        public Branch Branch { get; set; }
        public DeliveryRoute Route { get; set; }
        public string Admixture { get; set; }
        public decimal AdmixtureQuantity { get; set; }
        public decimal MaxSlump { get; set; }
        public DeliveryScheduleStatus ScheduleStatus { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public Employee ServiceEngineer { get; set; }
        public string DeliveryReceiptNumberDisplay
        {
            get
            {
                return string.Format("{0:yy}-{1}", DeliveryDate, DeliveryReceiptNumber);
            }
        }

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
        public override string ToString()
        {
            return ProjectDesign?.ToString();
        }
    }
}
