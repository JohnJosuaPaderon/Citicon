using System;
using System.Collections.Generic;

namespace Citicon.Data
{
    public class TallySheetItem
    {
        public TallySheetItem(ProjectDesign projectDesign)
        {
            ProjectDesign = projectDesign ?? throw new ArgumentNullException(nameof(projectDesign));
            Deliveries = new List<Delivery>();
        }

        public ProjectDesign ProjectDesign { get; }
        public List<Delivery> Deliveries { get; }
    }
}
