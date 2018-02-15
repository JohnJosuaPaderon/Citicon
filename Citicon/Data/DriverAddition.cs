namespace Citicon.Data
{
    public sealed class DriverAddition : EntityBase<ulong>
    {
        public DriverAddition(Employee employee)
        {
            Employee = employee;
        }

        public Employee Employee { get; }
        public decimal ShopRate { get; set; }
    }
}
