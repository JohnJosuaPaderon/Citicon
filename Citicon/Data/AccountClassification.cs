namespace Citicon.Data
{
    public sealed class AccountClassification : Sorschia.Data
    {
        private ulong id;
        private string code;
        private AccountType type;
        private string name;
        public ulong Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged(nameof(Id), value);
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
                    OnPropertyChanged(nameof(Code), value);
                }
            }
        }
        public AccountType Type
        {
            get { return type; }
            set
            {
                if (type != value)
                {
                    type = value;
                    OnPropertyChanged(nameof(Type), value);
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name), value);
                }
            }
        }
        public static bool operator ==(AccountClassification x, AccountClassification y)
        {
            return x?.id == y?.id;
        }
        public static bool operator !=(AccountClassification x, AccountClassification y) => !(x == y);
        public override bool Equals(object obj) => (obj is AccountClassification) ? this == (AccountClassification)obj : false;
        public override int GetHashCode() => id.GetHashCode();
    }
}
