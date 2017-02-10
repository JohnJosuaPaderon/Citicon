namespace Citicon.Data
{
    public sealed class Supplier : Sorschia.Data
    {
        private ulong id;
        private string code;
        private string description;
        private string address;
        private string contactnumber;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Supplier.Id", value);
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                code = value;
                OnPropertyChanged("Supplier.Code", value);
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Supplier.Description", value);
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged("Supplier.Address", value);
            }
        }
        public string ContactNumber
        {
            get { return contactnumber; }
            set
            {
                contactnumber = value;
                OnPropertyChanged("Supplier.ContactNumber", value);
            }
        }
        public static bool operator ==(Supplier x, Supplier y)
        {
            return
                x?.code == y?.code &&
                x?.description == y?.description;
        }
        public static bool operator !=(Supplier x, Supplier y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is Supplier) ? (obj as Supplier).id == id : false;
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
