namespace Citicon.Data
{
    public sealed class UInt32Range
    {
        public UInt32Range(uint start, uint end)
        {
            Start = start;
            End = end;
        }

        public uint Start { get; set; }
        public uint End { get; set; }
    }
}
