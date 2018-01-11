namespace Citicon.Data
{
    public class Project : EntityBase<ulong>
    {
        public Client Client { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public decimal TotalCost { get; set; }
        public bool Completed { get; set; }
        public ProjectType Type { get; set; }
        public decimal InitialPayment { get; set; }
        public double InitialCement { get; set; }
        public QuotationType QuotationType { get; set; }
        
        public override string ToString()
        {
            return Name;
        }
    }
}
