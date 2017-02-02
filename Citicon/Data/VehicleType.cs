namespace Citicon.Data
{
    public sealed class VehicleType : Sorschia.Data
    {
        private ulong id;
        private string code;
        private string description;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("VehicleType.Id", value);
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                code = value;
                OnPropertyChanged("VehicleType.Code", value);
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("VehicleType.Description", value);
            }
        }

        public static bool operator ==(VehicleType left, VehicleType right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.id == right.id;
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
            return id.GetHashCode();
        }
        public override string ToString()
        {
            return description;
        }
    }
}
