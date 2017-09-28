namespace Citicon.Data
{
    public class DeliveryConsumedCementSupplied
    {
        public Stock CementSupplied { get; set; }
        public Delivery Delivery { get; set; }
        public decimal Amount { get; set; }

        public static bool operator ==(DeliveryConsumedCementSupplied left, DeliveryConsumedCementSupplied right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DeliveryConsumedCementSupplied left, DeliveryConsumedCementSupplied right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            var value = obj as DeliveryConsumedCementSupplied;
            return
                CementSupplied.Equals(value.CementSupplied) &&
                Delivery.Equals(value.Delivery);
        }

        public override int GetHashCode()
        {
            return 
                CementSupplied.GetHashCode() ^
                Delivery.GetHashCode();
        }
    }
}
