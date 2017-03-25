namespace Citicon.Data
{
    public sealed class Vehicle
    {
        public ulong Id { get; set; }
        public VehicleType Type { get; set; }
        public string PhysicalNumber { get; set; }
        public string PlateNumber { get; set; }

        public static bool operator ==(Vehicle left, Vehicle right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Vehicle left, Vehicle right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Vehicle)
            {
                return (Vehicle)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{PhysicalNumber} / {PlateNumber}";
        }
    }
}
