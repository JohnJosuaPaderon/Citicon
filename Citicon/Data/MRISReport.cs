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
    }
}
