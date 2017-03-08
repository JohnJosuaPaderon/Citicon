namespace Citicon.Data
{
    public class Department
    {
        static Department()
        {
            Operation = new Department() { Id = 4 };
        }

        public static Department Operation { get; }

        public long Id { get; set; }
        public string Name { get; set; }

        public static bool operator ==(Department left, Department right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Department left, Department right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Department)
            {
                return (Department)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
