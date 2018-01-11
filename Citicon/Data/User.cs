namespace Citicon.Data
{
    public class User : EntityBase<ulong>
    {
        public static User CurrentUser;
        
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public bool Admin { get; set; }
        public string DisplayName { get; set; }
        public Module Module { get; set; }
        public bool Inventory_OutgoingStocksOnly { get; set; }
        
        public override string ToString()
        {
            return DisplayName;
        }
    }
}
