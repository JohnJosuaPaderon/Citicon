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
                return (DailyRate / 8) * RegularWorkingHours;
            }
        }

        public decimal SundayPay
        {
            get
            {
                return (DailyRate / 8) * SundayWorkingHours * 1.3M;
            }
        }

        public decimal SpecialHolidayPay
        {
            get
            {
                return (DailyRate / 8) * SpecialHolidayWorkingHours * 1.3M;
            }
        }

        public decimal SpecialHolidayOvertimePay
        {
            get
            {
                return (DailyRate / 8) * SpecialHolidayOvertimeWorkingHours * 1.6M;
            }
        }

        public decimal GrossPay
        {
            get
            {
                return BasicPay + RegularOvertimePay + SundayPay + OvertimeAllowance + Allowance + SpecialHolidayPay + SpecialHolidayOvertimePay;
            }
        }

        public decimal TotalDeduction
        {
            get
            {
                return WithholdingTax + Sss + CashAdvance + Pagibig + SunCellBill + PhilHealth;
            }
        }

        public decimal NetPay
        {
            get
            {
                return GrossPay - TotalDeduction;
            }
        }
    }
}
