namespace Citicon.Data
{
    public class DeliveryRoute : EntityBase<long>
    {
        public string Name { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public decimal Rate { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
