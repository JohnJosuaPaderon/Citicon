using System;
using System.Collections.Generic;

namespace Citicon.Data
{
    public class QuotationTransaction
    {
        public QuotationTransaction(Quotation quotation)
        {
            Quotation = quotation ?? throw new ArgumentNullException(nameof(quotation));
            Designs = new List<ProjectDesign>();
        }

        public Quotation Quotation { get; }
        public List<ProjectDesign> Designs { get; }
    }
}
