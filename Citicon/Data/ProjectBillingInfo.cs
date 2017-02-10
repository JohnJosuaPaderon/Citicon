namespace Citicon.Data
{
    public class ProjectBillingInfo
    {
        public Project Project { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public decimal RunningBalance { get; set; }
    }
}
