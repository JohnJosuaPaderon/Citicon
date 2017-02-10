namespace Citicon.Data
{
    public sealed class Company : Sorschia.Data
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
                OnPropertyChanged("Company.Id", value);
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                code = value;
                OnPropertyChanged("Company.Code", value);
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Company.Description", value);
            }
        }
        public static bool operator ==(Company x, Company y)
        {
            return
                x?.code == y?.code &&
                x?.description == y?.description;
        }
        public static bool operator !=(Company x, Company y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is Company) ? (obj as Company).id == id : false;
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
