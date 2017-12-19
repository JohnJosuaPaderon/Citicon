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
        public decimal BasicPay { get; set; }
        public decimal DailyRate { get; set; }
        public decimal VacationLeave { get; set; }
        public decimal SickLeave { get; set; }
        public decimal RegularWorkingHours { get; set; }
        public decimal NightDifferentialHours { get; set; }
        public decimal SundayHours { get; set; }
        public decimal SpecialHolidayHours { get; set; }
        public decimal SpecialHolidayOvertimeHours { get; set; }
        public decimal WithHoldingTax { get; set; }
        public decimal SSSER { get; set; }
        public decimal SSSEC { get; set; }
        public string VLSL
        {
            get
            {
                var stringBuilder = new StringBuilder();
                var hasVacationLeave = VacationLeave != 0;
                var hasSickLeave = SickLeave != 0;

                if (hasVacationLeave)
                {
                    stringBuilder.AppendFormat("{0}VL", VacationLeave.ToString("#.##"));

                    if (hasSickLeave)
                    {
                        stringBuilder.Append("/");
                    }
                }

                if (hasSickLeave)
                {
                    stringBuilder.AppendFormat("{0}SL", SickLeave.ToString("#.##"));
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
