using Citicon.DataManager;
using Citicon.Utilities;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public sealed class DriverPayrollEmployee : PayrollEmployeeBase<DriverPayroll>
    {
        public DriverPayrollEmployee(DriverPayroll payroll, Employee employee) : base(payroll, employee)
        {
        }

        public decimal ShopRate { get; set; }
        public decimal Holidays { get; private set; }
        public int WorkDays { get; private set; }
        public decimal TripsPay { get; private set; }

        public decimal ShopRatePay
        {
            get
            {
                return ShopRate * WorkDays;
            }
        }

        public bool IrregularitiesDetected
        {
            get
            {
                return
                    WorkDays < 0 ||
                    Holidays < 0;
            }
        }

        public async Task GetCalculatedValuesAsync()
        {
            var result = await WorkDaysCounter.CountWorkDaysAsync(this);

            Holidays = result.Holidays;
            WorkDays = result.WorkDays;
            TripsPay = await EmployeeManager.CountTripsPayAsync(Employee, Payroll.CutOff);
        }

        protected override decimal ComputeGrossPay()
        {
            return ShopRatePay + TripsPay + (Holidays * 378.50M);
        }

        protected override decimal ComputeTotalDeduction()
        {
            return WithholdingTax + Sss + SssEc + SssEr + CashAdvance + Pagibig + SunCellBill + PhilHealth + Others;
        }
    }
}
