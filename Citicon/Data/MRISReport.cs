using System;
using System.Collections.Generic;

namespace Citicon.Data
{
    public class MRISReport
    {
        public MRISReport()
        {
            Stocks = new List<Stock>();
        }

        public List<Stock> Stocks { get; }
        public string Usage { get; set; }
        public string ReceivedStoredBy { get; set; }
        public string InspectedAcceptedBy { get; set; }
        public string ApprovedBy { get; set; }
        public string MRISNumber { get; private set; }
        public Supplier Supplier { get; private set; }
        public DateTime DeliveryDate { get; private set; }
    }
}
