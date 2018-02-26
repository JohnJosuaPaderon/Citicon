using System;
using System.Text;

namespace Citicon.Data
{
    public class Employee : EntityBase<long>
    {
        public Employee()
        {
            Addition = new EmployeeAddition(this);
            Deduction = new EmployeeDeduction(this);
        }

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
        public DateTime EmploymentDate { get; set; }
        public string TIN { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string EmergencyContactPerson { get; set; }
        public string EmergencyContactPersonNumber { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
        public string SSSNumber { get; set; }
        public DateTime R1ADate { get; set; }
        public string PagIbigNumber { get; set; }
        public string PhilHealthNumber { get; set; }
        public DateTime PhilHealthRegistrationDate { get; set; }
        public string PagIbigRTN { get; set; }
        public DateTime PagIbigRegistrationDate { get; set; }
        public uint PagIbigRTNDependentNumber { get; set; }
        public decimal VacationLeave { get; set; }
        public decimal SickLeave { get; set; }
        public decimal Absences { get; set; }
        public PayrollGroup PayrollGroup { get; set; }
        public decimal ShopRate { get; set; }

        public string FullName
        {
            get
            {
                var sb = new StringBuilder();
                var lastName = LastName?.Trim();
                var firstName = FirstName?.Trim();
                var hasLastName = !string.IsNullOrEmpty(lastName);
                var hasFirstName = !string.IsNullOrEmpty(firstName);

                if (hasLastName)
                {
                    sb.Append(lastName);
                }

                if (hasLastName && hasFirstName)
                {
                    sb.Append(", ");
                }

                if (hasFirstName)
                {
                    sb.Append(firstName);
                }

                if (hasFirstName)
                {
                    sb.Append(" ");
                }

                return sb.ToString();
            }
        }

        public string FullName2
        {
            get
            {
                var sb = new StringBuilder();
                var hasLastName = !string.IsNullOrWhiteSpace(LastName);
                var hasFirstName = !string.IsNullOrWhiteSpace(FirstName);

                if (hasLastName)
                {
                    sb.Append(LastName.Trim());

                    if (hasFirstName)
                    {
                        sb.Append(", ");
                    }
                }

                if (hasFirstName)
                {
                    sb.Append(FirstName.Trim());
                }

                return sb.ToString();
            }
        }

        public EmployeeAddition Addition { get; internal set; }
        public EmployeeDeduction Deduction { get; internal set; }

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

                if (hasFirstName || hasMiddleName)
                {
                    sb.Append(", ");
                }
            }

            if (hasFirstName)
            {
                sb.Append(firstName);

                if (hasMiddleName)
                {
                    sb.Append(" ");
                }
            }

            if (hasMiddleName)
            {
                sb.Append(middleName);
            }

            return sb.ToString();
        }
    }
}
