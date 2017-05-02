using System;

namespace Citicon.Data
{
    public class TripReportProject
    {
        public TripReportProject(Project project)
        {
            Project = project ?? throw new ArgumentNullException(nameof(project));
            Deliveries = new TripReportDeliveryCollection(this);
        }

        public Project Project { get; }
        public TripReportDeliveryCollection Deliveries { get; }

        public static bool operator ==(TripReportProject left, TripReportProject right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Project == right.Project;
        }

        public static bool operator !=(TripReportProject left, TripReportProject right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is TripReportProject)
            {
                return (TripReportProject)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Project.GetHashCode();
        }
    }
}
