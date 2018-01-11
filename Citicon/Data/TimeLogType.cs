namespace Citicon.Data
{
    public sealed class TimeLogType : EntityBase<ulong>
    {
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
