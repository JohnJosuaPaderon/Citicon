using System;

namespace Citicon.Data
{
    public abstract class PayrollEmployeeBase<TPayroll> : EntityBase<ulong>
        where TPayroll : PayrollBase
    {
        public PayrollEmployeeBase(TPayroll payroll, Employee employee)
        {
            Payroll = payroll ?? throw new ArgumentNullException(nameof(payroll));
            Employee = employee ?? throw new ArgumentNullException(nameof(Employee));
        }

        public TPayroll Payroll { get; }
        public decimal VacationLeave { get; set; }
        public decimal SickLeave { get; set; }
        public Employee Employee { get; }
        public decimal WithholdingTax { get; set; }
        public decimal Sss { get; set; }
        public decimal SssEr { get; set; }
        public decimal SssEc { get; set; }
        public decimal Pagibig { get; set; }
        public decimal PhilHealth { get; set; }
        public decimal CashAdvance { get; set; }
        public decimal SunCellBill { get; set; }
        public decimal Others { get; set; }

        public decimal GrossPay => ComputeGrossPay();
        public decimal TotalDeduction => ComputeTotalDeduction();
        public decimal NetPay => GrossPay - TotalDeduction;

        protected abstract decimal ComputeGrossPay();
        protected abstract decimal ComputeTotalDeduction();
    }
}
