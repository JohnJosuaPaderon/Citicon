namespace Citicon.Data
{
    public sealed class SemiMonthlyPayrollEmployee : PayrollEmployeeBase<SemiMonthlyPayroll>
    {
        public SemiMonthlyPayrollEmployee(SemiMonthlyPayroll payroll, Employee employee) : base(payroll, employee)
        {
        }

        public decimal RegularWorkingHours { get; set; }
        public decimal RegularOvertimeWorkingHours { get; set; }
        public decimal SundayWorkingHours { get; set; }
        public decimal SpecialHolidayWorkingHours { get; set; }
        public decimal SpecialHolidayOvertimeWorkingHours { get; set; }
        public decimal NightDifferentialWorkingHours { get; set; }

        public decimal RegularOvertimePay
        {
            get
            {
                return 0;
            }
        }

        public decimal SundayPay
        {
            get
            {
                return 0;
            }
        }

        public decimal SpecialHolidayPay
        {
            get
            {
                return 0;
            }
        }

        public decimal SpecialHolidayOvertimePay
        {
            get
            {
                return 0;
            }
        }

        public decimal GrossPay
        {
            get
            {
                return 0;
            }
        }

        public decimal TotalDeduction
        {
            get
            {
                return 0;
            }
        }

        public decimal NetPay
        {
            get
            {
                return 0;
            }
        }
    }
}
