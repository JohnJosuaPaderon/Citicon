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
        public decimal OtherDeduction { get; set; }
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

        public decimal GrossPay
        {
            get
            {
                return ShopRatePay + TripsPay;
            }
        }

        public decimal TotalDeduction
        {
            get
            {
                return WithholdingTax + Sss + CashAdvance + Pagibig + SunCellBill + PhilHealth + OtherDeduction;
            }
        }

        public decimal NetPay
        {
            get
            {
                return GrossPay - TotalDeduction;
            }
        }

        public async Task GetCalculatedValuesAsync()
        {
            var result = await WorkDaysCounter.CountWorkDaysAsync(this);

            Holidays = result.Holidays;
            WorkDays = result.WorkDays;
            TripsPay = await EmployeeManager.CountTripsPayAsync(Employee, Payroll.CutOff);
        }
    }
}
