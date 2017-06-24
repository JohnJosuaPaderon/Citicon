namespace Citicon.Data
{
    public class JobPosition
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }

        public static bool operator ==(JobPosition left, JobPosition right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JobPosition left, JobPosition right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            var value = obj as JobPosition;
            return Id.Equals(value.Id);
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
