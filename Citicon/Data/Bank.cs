namespace Citicon.Data
{
    public sealed class Bank : Sorschia.Data
    {
        private ulong id;
        private string code;
        private string description;
        public ulong Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged("Bank.Id", value);
                }
            }
        }
        public string Code
        {
             get { return code; }
            set
            {
                if (code != value)
                {
                    code = value;
                    OnPropertyChanged("Bank.Code", value);
                }
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    if (description != value)
                    {
                        description = value;
                        OnPropertyChanged("Bank.Description", value);
                    }
                }
            }
        }
        public static bool operator ==(Bank x, Bank y)
        {
            return
                x?.code == y?.code &&
                x?.description == y?.description;
        }
        public static bool operator !=(Bank x, Bank y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is Bank) ? (obj as Bank).id == id : false;
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
