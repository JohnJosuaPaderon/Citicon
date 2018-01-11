namespace Citicon.Data
{
    public class Payroll : EntityBase<ulong>
    {
        public Payroll()
        {
            Employees = new EmployeePayrollCollection(this);
        }
        
        public DateTimeRange DateRange { get; set; }
        public Branch Branch { get; set; }
        public EmployeePayrollCollection Employees { get; }

    }
}
