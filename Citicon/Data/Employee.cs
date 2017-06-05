using System;
using System.Text;

namespace Citicon.Data
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public JobPosition Position { get; set; }
        public JobPosition JobPosition
        {
            get { return Position; }
            set
            {
                Position = value;
            }
        }
        public Branch Branch { get; set; }
        public Company Company { get; set; }
        public PayrollType PayrollType { get; set; }
        public DateTime BirthDate { get; set; }
        public CivilStatus CivilStatus { get; set; }
        public string TIN { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string EmergencyContactPerson { get; set; }
        public string EmergenctContactPersonNumber { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
        public string SSSNumber { get; set; }
        public DateTime R1ADate { get; set; }
        public string PagIbigNumber { get; set; }
        public string PhilHealthNumber { get; set; }
        public DateTime PhilHealthRegistrationDate { get; set; }
        public string PagIbigRTN { get; set; }
        public DateTime PagIbigRTNRegistrationDate { get; set; }
        public uint PagIbigRTNDependentNumber { get; set; }
        public decimal VacationLeave { get; set; }
        public decimal SickLeave { get; set; }
        public decimal Absences { get; set; }
        public decimal BasicPay { get; set; }
        public decimal DailyRate { get; set; }
        public decimal Allowance { get; set; }
        public decimal OTAllowance { get; set; }
        public decimal SSSDeduction { get; set; }
        public decimal SSSERDeduction { get; set; }
        public decimal SSSECDeduction { get; set; }
        public decimal WithHoldingTax { get; set; }
        public decimal PagIbigDeduction { get; set; }
        public decimal PhilHealthDeduction { get; set; }

        public static bool operator ==(Employee left, Employee right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Employee)
            {
                return (Employee)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var lastName = LastName?.Trim();
            var firstName = FirstName?.Trim();
            var middleName = MiddleName?.Trim();
            var hasLastName = !string.IsNullOrEmpty(lastName);
            var hasFirstName = !string.IsNullOrEmpty(firstName);
            var hasMiddleName = !string.IsNullOrEmpty(middleName);

            if (hasLastName)
            {
                sb.Append(lastName);
            }

            if (hasLastName && (hasFirstName || hasMiddleName))
            {
                sb.Append(", ");
            }

            if (hasFirstName)
            {
                sb.Append(firstName);
            }

            if (hasFirstName && hasMiddleName)
            {
                sb.Append(" ");
            }

            if (hasMiddleName)
            {
                sb.Append(middleName);
            }

            return sb.ToString();
        }
    }
}
