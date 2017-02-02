using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public JobPosition Position { get; set; }

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
