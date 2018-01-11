using System.Text;

namespace Citicon.Data
{
    public class ProjectDesign : EntityBase<ulong>
    {
        public Project Project { get; set; }
        public decimal PricePerCubicMeter { get; set; }
        public decimal InitialVolume { get; set; }
        public ProjectDesignMixType MixType { get; set; }
        public decimal Psi { get; set; }
        public ProductAggregate Aggregate { get; set; }
        public ProductStrength Strength { get; set; }
        public decimal CementFactor { get; set; }
        public bool ForApproval { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public Quotation Quotation { get; set; }
        
        public override string ToString()
        {
            var displayBuilder = new StringBuilder();

            displayBuilder.Append($"{Psi} ");
            displayBuilder.Append($"{Aggregate} ");
            displayBuilder.Append($"{Strength} ");
            displayBuilder.Append($"{MixType} ");

            if (Project.Type == ProjectType.CementSupplied && CementFactor > 0)
            {
                displayBuilder.Append($"CF {CementFactor}");
            }

            return displayBuilder.ToString();
        }
    }
}
