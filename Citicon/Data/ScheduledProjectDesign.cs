using System;

namespace Citicon.Data
{
    public class ScheduledProjectDesign
    {
        public ProjectDesign Design { get; set; }
        public DateTime ScheduledDate { get; set; }
        public bool UseRangeDate { get; set; }
        public DateTime RangeEnd { get; set; }
        public ScheduledProjectDesignStatus Status { get; set; }
        public BillingStructureType StructureType { get; set; }
        public decimal MaximumVolume { get; set; }

        public static bool operator ==(ScheduledProjectDesign left, ScheduledProjectDesign right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return
                left.Design == right.Design &&
                left.ScheduledDate.Date == right.ScheduledDate.Date;
        }

        public static bool operator !=(ScheduledProjectDesign left, ScheduledProjectDesign right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is ScheduledProjectDesign)
            {
                return (ScheduledProjectDesign)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Design.GetHashCode() ^ ScheduledDate.Date.GetHashCode();
        }

        public override string ToString()
        {
            return UseRangeDate ?
                    $"{ScheduledDate.ToString("MMMM dd, yyyy")} to {RangeEnd.ToString("MMMM dd, yyyy")}" :
                    ScheduledDate.ToString("MMMM dd, yyyy");
        }
    }
}
