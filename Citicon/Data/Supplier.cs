namespace Citicon.Data
{
    public sealed class Supplier : EntityBase<ulong>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        
        public override string ToString()
        {
            return Description;
        }
    }
}
