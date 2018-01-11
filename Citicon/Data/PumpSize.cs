namespace Citicon.Data
{
    public sealed class PumpSize : EntityBase<ulong>
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
