using System;

namespace Citicon.Data
{
    public class ProjectDesignLoadCutOff : EntityBase<ulong>
    {
        private const string FORMAT_FULL = "MMMM d, yyyy HH:mm";

        public ProjectDesign Design { get; set; }
        public DateTime? Begin { get; set; }
        public DateTime? End { get; set; }

        public override string ToString()
        {
            return $"{Begin?.ToString(FORMAT_FULL) ?? ("INVALID")} - {End?.ToString(FORMAT_FULL) ?? ("INVALID")}";
        }
    }
}
