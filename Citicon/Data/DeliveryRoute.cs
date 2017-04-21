namespace Citicon.Data
{
    public class DeliveryRoute
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public decimal Rate { get; set; }

        public static bool operator ==(DeliveryRoute left, DeliveryRoute right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(DeliveryRoute left, DeliveryRoute right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is DeliveryRoute)
            {
                return (DeliveryRoute)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
