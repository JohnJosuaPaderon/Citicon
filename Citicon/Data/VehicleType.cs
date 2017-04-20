namespace Citicon.Data
{
    public sealed class VehicleType
    {
        static VehicleType()
        {
            TransitMixer = new VehicleType()
            {
                Code = "002",
                Description = "TRANSIT MIXER"
            };
        }

        public static VehicleType TransitMixer { get; }

        public ulong Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public static bool operator ==(VehicleType left, VehicleType right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(VehicleType left, VehicleType right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is VehicleType)
            {
                return (VehicleType)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
