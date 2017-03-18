using Citicon.Data;
using System;

namespace Citicon.DataManager
{
    public static class QuotationStatusManager
    {
        public static QuotationStatus Parse(string value)
        {
            Enum.TryParse(value, out QuotationStatus quotationStatus);
            return quotationStatus;
        }

        public static string ToDisplay(QuotationStatus quotationStatus)
        {
            switch (quotationStatus)
            {
                case QuotationStatus.Approved:
                    return "Approved";
                case QuotationStatus.ForRevision:
                    return "For Revision";
                case QuotationStatus.UnderNegotiation:
                    return "Under Negotiation";
                case QuotationStatus.FinalApproved:
                    return "Final Approved";
            }

            return "";
        }

        public static QuotationStatus FromDisplay(string value)
        {
            switch (value)
            {
                case "Approved":
                    return QuotationStatus.Approved;
                case "For Revision":
                    return QuotationStatus.ForRevision;
                case "Under Negotiation":
                    return QuotationStatus.UnderNegotiation;
                case "Final Approved":
                    return QuotationStatus.FinalApproved;
            }

            return QuotationStatus.Undefined;
        }
    }
}
