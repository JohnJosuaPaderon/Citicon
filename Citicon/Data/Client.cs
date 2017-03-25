namespace Citicon.Data
{
    public class Client
    {
        public ulong Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public string Tin { get; set; }
        public string Position { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhotoPath { get; set; }
        public string PresidentName { get; set; }
        public string PresidentTelephoneNumber { get; set; }
        public string PresidentMobileNumber { get; set; }
        public string Designation { get; set; }
        public Employee Employee { get; set; }
        public bool Legitimate { get; set; }

        public static bool operator ==(Client left, Client right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Client left, Client right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Client)
            {
                return (Client)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return CompanyName;
        }
    }
}
