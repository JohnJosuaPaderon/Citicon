namespace Citicon.Data
{
    public class Client : EntityBase<ulong>
    {
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

        public override string ToString()
        {
            return CompanyName;
        }
    }
}
