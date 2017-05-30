using Citicon.Data;
using Citicon.DataProcess;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class BillingPaymentManager
    {
        public static async Task SavePaymentAsync(BillingPayment billingPayment)
        {
            using (var savePayment = new SavePayment(billingPayment))
            {
                await savePayment.ExecuteAsync();
            }
        }
    }
}
