namespace Citicon.Data
{
    public class User : Sorschia.Data
    {
        public static User CurrentUser;
        private ulong id;
        private string username;
        private string password;
        private bool active;
        private bool admin;
        private string displayname;
        private Module module;
        private bool _Inventory_OutgoingStocksOnly;

        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("User.Id", value);
            }
        }
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged("User.Username", value);
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("User.Password", value);
            }
        }
        public bool Active
        {
            get { return active; }
            set
            {
                active = value;
                OnPropertyChanged("User.Active", value);
            }
        }
        public bool Admin
        {
            get { return admin; }
            set
            {
                admin = value;
                OnPropertyChanged("User.Admin", value);
            }
        }
        public string DisplayName
        {
            get { return displayname; }
            set
            {
                displayname = value;
                OnPropertyChanged("User.DisplayName", value);
            }
        }
        public Module Module
        {
            get { return module; }
            set
            {
                module = value;
                OnPropertyChanged("User.Module", value);
            }
        }
        public bool Inventory_OutgoingStocksOnly
        {
            get { return _Inventory_OutgoingStocksOnly; }
            set
            {
                if (_Inventory_OutgoingStocksOnly != value)
                {
                    _Inventory_OutgoingStocksOnly = value;
                    OnPropertyChanged("User.Inventory_OutgoingStocksOnly", value);
                }
            }
        }

        public static bool operator ==(User left, User right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(User left, User right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is User)
            {
                return (User)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return displayname;
        }
    }
}
