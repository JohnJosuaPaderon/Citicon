using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class BillingPaymentManager
    {
        static BillingPaymentManager()
        {
            _Source = new Dictionary<ulong, BillingPayment>();
        }

        private static readonly Dictionary<ulong, BillingPayment> _Source;

        private static BillingPayment TryAddUpdate(BillingPayment payment)
        {
            if (payment != null)
            {
                if (_Source.ContainsKey(payment.Id))
                {
                    _Source[payment.Id] = payment;
                }
                else
                {
                    _Source.Add(payment.Id, payment);
                }
            }

            return payment;
        }

        public static async Task SavePaymentAsync(BillingPayment billingPayment)
        {
            using (var savePayment = new SavePayment(billingPayment))
            {
                await savePayment.ExecuteAsync();
            }
        }

        public static async Task<BillingPayment> GetByIdAsync(ulong billingPaymentId)
        {
            if (billingPaymentId > 0)
            {
                if (_Source.ContainsKey(billingPaymentId))
                {
                    return _Source[billingPaymentId];
                }
                else
                {
                    using (var process = new GetBillingPaymentById(billingPaymentId))
                    {
                        return TryAddUpdate(await process.ExecuteAsync());
                    }
                }
            }
            else
            {
                return null;
            }
        }
    }
}
