namespace Citicon.Data
{
    public class ProductStrength : EntityBase<long>
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
