using Citicon.Data;
using System;

namespace Citicon.DataProcess
{
    internal sealed class ValidateProjectDesign : IDisposable
    {
        public ValidateProjectDesign(ProjectDesign projectDesign)
        {
            ProjectDesign = projectDesign ?? throw new ArgumentNullException(nameof(projectDesign));
        }

        private ProjectDesign ProjectDesign;

        public void Dispose()
        {
            ProjectDesign = null;
        }

        public ValidationResult Execute()
        {
            if (ProjectDesign.Aggregate == null)
            {
                return new ValidationResult(false, "Invalid aggregate.");
            }
            //else if (ProjectDesign.Project.Type == ProjectType.CementSupplied && ProjectDesign.CementFactor == 0)
            //{
            //    return new ValidationResult(false, "Invalid cement factor.");
            //}
            else if (ProjectDesign.PricePerCubicMeter == 0)
            {
                return new ValidationResult(false, "Invalid price/cu.m.");
            }
            //else if (ProjectDesign.Strength == null)
            //{
            //    return new ValidationResult(false, "Invalid strength.");
            //}
            else
            {
                return new ValidationResult(true);
            }
        }
    }
}
