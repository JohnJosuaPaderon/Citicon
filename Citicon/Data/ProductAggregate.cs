namespace Citicon.Data
{
    public class ProductAggregate : EntityBase<long>
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
