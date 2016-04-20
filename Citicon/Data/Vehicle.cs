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
        public static bool operator ==(Vehicle x, Vehicle y)
        {
            return
                x?.type == y?.type &&
                x?.physicalnumber == y?.physicalnumber &&
                x?.platenumber == y?.platenumber;
        }
        public static bool operator !=(Vehicle x, Vehicle y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is Vehicle) ? (obj as Vehicle).id == id : false;
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        public override string ToString()
        {
            return $"{type.Description} ({platenumber})";
        }
    }
}
