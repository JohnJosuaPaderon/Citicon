namespace Citicon.Data
{
    public class EmployeeLogin : EntityBase<ulong>
    {
        public Employee Employee { get; set; }
        public uint LoginCode { get; set; }

        public static bool operator ==(EmployeeLogin left, EmployeeLogin right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(EmployeeLogin left, EmployeeLogin right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is EmployeeLogin)
            {
                return (EmployeeLogin)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString() => Employee?.ToString();
    }
}
