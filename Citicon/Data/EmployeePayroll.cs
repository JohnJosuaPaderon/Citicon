using System;
using System.Text;

namespace Citicon.Data
{
    public class EmployeePayroll : IComparable<EmployeePayroll>
    {
        public EmployeePayroll(Payroll payroll)
        {
            Payroll = payroll;
        }

        public Payroll Payroll { get; internal set; }
        public Employee Employee { get; set; }
        public decimal VacationLeave { get; set; }
        public decimal SickLeave { get; set; }
        public decimal Rate { get; set; }
        public decimal BasicPay { get; set; }
        public decimal RegularWorkingHours { get; set; }
        public decimal RegularOvertimePay { get; set; }
        public decimal NightDifferentialOvertimeHours { get; set; }
        public decimal SundayWorkingHours { get; set; }
        public decimal SundayPay { get; set; }
        public decimal SpecialHolidayWorkingHours { get; set; }
        public decimal SpecialHolidayPay { get; set; }
        public decimal SpecialHolidayOvertimeWorkingHours { get; set; }
        public decimal SpecialHolidayOvertimePay { get; set; }
        public decimal OvertimePay { get; set; }
        public decimal Allowance { get; set; }
        public decimal GrossPay { get; set; }
        public decimal WithholdingTax { get; set; }
        public decimal Sss { get; set; }
        public decimal SssLoan { get; set; }
        public decimal PagibigLoan { get; set; }
        public decimal PhilHealth { get; set; }
        public decimal CashAdvance { get; set; }
        public decimal SunCellBill { get; set; }
        public string VLSL
        {
            get
            {
                var stringBuilder = new StringBuilder();
                var hasVacationLeave = VacationLeave != 0;
                var hasSickLeave = SickLeave != 0;

                if (hasVacationLeave)
                {
                    stringBuilder.AppendFormat("{0:#.0#}VL", VacationLeave);

                    if (hasSickLeave)
                    {
                        stringBuilder.Append("/");
                    }
                }

                if (hasSickLeave)
                {
                    stringBuilder.AppendFormat("{0:#.0#}SL", SickLeave);
                }

                return stringBuilder.ToString();
            }
        }
        public PayrollGroup Group { get; set; }

        public static bool operator ==(EmployeePayroll left, EmployeePayroll right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Employee == right.Employee;
        }

        public static bool operator !=(EmployeePayroll left, EmployeePayroll right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is EmployeePayroll)
            {
                return (EmployeePayroll)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Employee.GetHashCode();
        }

        public int CompareTo(EmployeePayroll other)
        {
            return string.Compare(Employee.ToString(), other.ToString());
        }
    }
}
