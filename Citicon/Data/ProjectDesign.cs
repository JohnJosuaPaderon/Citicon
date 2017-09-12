using System.Text;

namespace Citicon.Data
{
    public class ProjectDesign
    {
        public ulong Id { get; set; }
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

        public static bool operator ==(ProjectDesign left, ProjectDesign right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(ProjectDesign left, ProjectDesign right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is ProjectDesign)
            {
                return (ProjectDesign)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override string ToString()
        {
            var displayBuilder = new StringBuilder();

            displayBuilder.Append($"{MixType} ");
            displayBuilder.Append($"{Psi} ");
            displayBuilder.Append($"{Aggregate} ");
            displayBuilder.Append($"{Strength} ");

            if (Project.Type == ProjectType.CementSupplied && CementFactor > 0)
            {
                displayBuilder.Append($"CF {CementFactor}");
            }

            return displayBuilder.ToString();
        }
    }
}
