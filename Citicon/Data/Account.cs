namespace Citicon.Data
{
    public sealed class Account : Sorschia.Data
    {
        private ulong id;
        private string code;
        private AccountType type;
        private AccountClassification classification;
        private AccountSubClassification subclassification;
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
        public AccountClassification Classification
        {
            get { return classification; }
            set
            {
                if (classification != value)
                {
                    classification = value;
                    OnPropertyChanged(nameof(Classification), value);
                }
            }
        }
        public AccountSubClassification SubClassification
        {
            get { return subclassification; }
            set
            {
                if (subclassification != value)
                {
                    subclassification = value;
                    OnPropertyChanged(nameof(SubClassification), value);
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
        public static bool operator ==(Account x, Account y) => x?.id == y?.id;
        public static bool operator !=(Account x, Account y) => !(x == y);
        public override bool Equals(object obj) => (obj is Account) ? this == (Account)obj : false;
        public override int GetHashCode() => id.GetHashCode();
        public override string ToString() => name;
    }
}
