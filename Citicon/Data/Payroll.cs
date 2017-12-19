namespace Citicon.Data
{
    public class Payroll
    {
        public Payroll()
        {
            Employees = new EmployeePayrollCollection(this);
        }

        public ulong Id { get; set; }
        public DateTimeRange DateRange { get; set; }
        public Branch Branch { get; set; }
        public EmployeePayrollCollection Employees { get; }

    }
}
