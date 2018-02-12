using Citicon.Utilities;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public sealed class SemiMonthlyPayrollEmployee : PayrollEmployeeBase<SemiMonthlyPayroll>
    {
        public SemiMonthlyPayrollEmployee(SemiMonthlyPayroll payroll, Employee employee) : base(payroll, employee)
        {
        }

        public decimal RegularWorkingHours { get; private set; }
        public decimal RegularOvertimeWorkingHours { get; private set; }
        public decimal SundayWorkingHours { get; private set; }
        public decimal SpecialHolidayWorkingHours { get; private set; }
        public decimal SpecialHolidayOvertimeWorkingHours { get; private set; }
        public decimal NightDifferentialWorkingHours { get; private set; }

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

        public bool IrregularWorkingHoursDetected
        {
            get
            {
                return
                    RegularWorkingHours < 0 ||
                    RegularOvertimeWorkingHours < 0 ||
                    SundayWorkingHours < 0 ||
                    SpecialHolidayWorkingHours < 0 ||
                    SpecialHolidayOvertimeWorkingHours < 0 ||
                    NightDifferentialWorkingHours < 0;
            }
        }

        public async Task CountTimeLogHoursAsync()
        {
            RegularWorkingHours = await RegularWorkingHoursCounter.CountAsync(Employee, Payroll.CutOff);
            RegularOvertimeWorkingHours = await RegularOvertimeWorkingHoursCounter.CountAsync(Employee, Payroll.CutOff);
            SundayWorkingHours = await SundayWorkingHoursCounter.CountAsync(Employee, Payroll.CutOff);
            SpecialHolidayWorkingHours = await SpecialHolidayWorkingHoursCounter.CountAsync(Employee, Payroll.CutOff);
            SpecialHolidayOvertimeWorkingHours = await SpecialHolidayOvertimeWorkingHoursCounter.CountAsync(Employee, Payroll.CutOff);
            NightDifferentialWorkingHours = await NightDifferentialWorkingHoursCounter.CountAsync(Employee, Payroll.CutOff);
        }
    }
}
