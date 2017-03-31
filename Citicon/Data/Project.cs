namespace Citicon.Data
{
    public class Project
    {
        public ulong Id { get; set; }
        public Client Client { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public decimal TotalCost { get; set; }
        public bool Completed { get; set; }
        public ProjectType Type { get; set; }
        public decimal InitialPayment { get; set; }
        public double InitialCement { get; set; }

        public static bool operator ==(Project left, Project right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(Project left, Project right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Project)
            {
                return (Project)arg == this;
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
