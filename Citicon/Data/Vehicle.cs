namespace Citicon.Data
{
    public sealed class Vehicle : Sorschia.Data
    {
        private ulong id;
        private VehicleType type;
        private string physicalnumber;
        private string platenumber;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Vehicle.Id", value);
            }
        }
        public VehicleType Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Vehicle.Type", value);
            }
        }
        public string PhysicalNumber
        {
            get { return physicalnumber; }
            set
            {
                physicalnumber = value;
                OnPropertyChanged("Vehicle.PhysicalNumber", value);
            }
        }
        public string PlateNumber
        {
            get { return platenumber; }
            set
            {
                platenumber = value;
                OnPropertyChanged("Vehicle.PlateNumber", value);
            }
        }
        public static bool operator ==(Vehicle left, Vehicle right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.id == right.id;
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
            return id.GetHashCode();
        }
        public override string ToString()
        {
            return $"{physicalnumber} / {platenumber}";
        }
    }
}
