namespace Citicon.Data
{
    public class User
    {
        public static User CurrentUser;

        public ulong Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public bool Admin { get; set; }
        public string DisplayName { get; set; }
        public Module Module { get; set; }
        public bool Inventory_OutgoingStocksOnly { get; set; }

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
            return DisplayName;
        }
    }
}
