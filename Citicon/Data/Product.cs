namespace Citicon.Data
{
    public class Product : EntityBase<long>
    {
        public long ProjectId { get; set; }
        public long DesignId { get; set; }
        public double PricePerCubicMeter { get; set; }
        public int InitialVolume { get; set; }
        public string Remarks { get; set; }
        public bool IsBilled { get; set; }
        public string DesignMixType { get; set; }
        public ProductStrength Strength { get; set; }
        public ProductAggregate Aggregate { get; set; }
        public double Psi { get; set; }
    }
}
