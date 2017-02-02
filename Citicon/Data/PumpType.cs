namespace Citicon.Data
{
    public class PumpType
    {
        public ulong Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return (obj is PumpType) ? ((PumpType)obj).Id == Id : false;
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
