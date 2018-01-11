namespace Citicon.Data
{
    public class PumpType : EntityBase<ulong>
    {
        public string Name { get; set; }
        
        public override string ToString()
        {
            return Name;
        }
    }
}
