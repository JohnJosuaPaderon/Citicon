using System;

namespace Citicon.Data
{
    public static class BillingPaymentTypeParser
    {
        public static BillingPaymentType Parse(string value)
        {
            Enum.TryParse(value, out BillingPaymentType result);
            return result;
        }
    }
}
