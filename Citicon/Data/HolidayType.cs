namespace Citicon.Data
{
    public class HolidayType : EntityBase<ulong>
    {
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
