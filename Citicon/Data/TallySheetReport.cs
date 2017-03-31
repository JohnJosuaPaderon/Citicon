using System;
using System.Collections.Generic;

namespace Citicon.Data
{
    public class TallySheetReport
    {
        public TallySheetReport()
        {
            Items = new List<TallySheetItem>();
        }

        public string Dispatcher { get; set; }
        public DateTime DeliveryDate { get; set; }
        public List<TallySheetItem> Items { get; }
    }
}
