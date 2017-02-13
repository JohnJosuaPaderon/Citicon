namespace Citicon.Data
{
    public sealed class BankAccount : Sorschia.Data
    {
        private ulong id;
        private Bank bank;
        private string code;
        private string description;
        private ulong chequenumberstart;
        private ulong chequenumberend;
        private ulong chequenumber;
        public ulong Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged("BankAccount.Id", value);
                }
            }
        }
        public Bank Bank
        {
            get { return bank; }
            set
            {
                if (bank != value)
                {
                    bank = value;
                    OnPropertyChanged("BankAccount.Bank", bank);
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
                    OnPropertyChanged("BankAccount.Code", value);
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
                    description = value;
                    OnPropertyChanged("BankAccount.Description", value);
                }
            }
        }
        public ulong ChequeNumberStart
        {
            get { return chequenumberstart; }
            set
            {
                if (chequenumberstart != value)
                {
                    chequenumberstart = value;
                    OnPropertyChanged("BankAccount.ChequeNumberStart", value);
                }
            }
        }
        public ulong ChequeNumberEnd
        {
            get { return chequenumberend; }
            set
            {
                if (chequenumberend != value)
                {
                    chequenumberend = value;
                    OnPropertyChanged("BankAccount.ChequeNumberEnd", value);
                }
            }
        }
        public ulong ChequeNumber
        {
            get { return chequenumber; }
            set
            {
                if (chequenumber != value)
                {
                    chequenumber = value;
                    OnPropertyChanged("BankAccount.ChequeNumber", value);
                }
            }
        }
        public static bool operator ==(BankAccount x, BankAccount y)
        {
            return
                x?.bank == y?.bank &&
                x?.code == y?.code &&
                x?.description == y?.description;
        }
        public static bool operator !=(BankAccount x, BankAccount y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is BankAccount) ? (obj as BankAccount).id == id : false;
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
