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
        public static bool operator ==(VehicleType x, VehicleType y)
        {
            return
                x?.code == y?.code &&
                x?.description == y?.description;
        }
        public static bool operator !=(VehicleType x, VehicleType y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is VehicleType) ? (obj as VehicleType).id == id : false;
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
