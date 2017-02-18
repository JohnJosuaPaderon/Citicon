namespace Citicon.Data
{
    public sealed class TimeLogType
    {
        public ulong Id { get; set; }
        public string Description { get; set; }

        public static bool operator ==(TimeLogType left, TimeLogType right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(TimeLogType left, TimeLogType right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is TimeLogType)
            {
                return (TimeLogType)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
