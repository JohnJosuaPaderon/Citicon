using Citicon.Data;
using System;

namespace Citicon.DataProcess
{
    internal sealed class ValidateProject : IDisposable
    {
        public ValidateProject(Project project)
        {
            Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        private Project Project;

        public void Dispose()
        {
            Project = null;
        }

        public ValidationResult Execute()
        {
            if (Project.Client == null)
            {
                return new ValidationResult(false, "Invalid client.");
            }
            else if (string.IsNullOrWhiteSpace(Project.Name))
            {
                return new ValidationResult(false, "Invalid name.");
            }
            else if (Project.Type == ProjectType.Undefined)
            {
                return new ValidationResult(false, "Invalid type.");
            }
            else
            {
                return new ValidationResult(true);
            }
        }
    }
}
