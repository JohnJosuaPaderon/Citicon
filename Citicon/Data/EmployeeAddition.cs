namespace Citicon.Data
{
    public sealed class EmployeeAddition : EntityBase<ulong>
    {
        public EmployeeAddition(Employee employee)
        {
            Employee = employee;
        }

        public Employee Employee { get; }

        public decimal DailyRate { get; set; }
        public decimal BasicPay { get; set; }
        public decimal Allowance { get; set; }
        public decimal OvertimeAllowance { get; set; }
    }
}
