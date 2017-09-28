using Citicon.Data;
using Citicon.DataProcess;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class DeliveryConsumedCementSuppliedManager
    {
        public static async Task<DeliveryConsumedCementSupplied> GetAsync(Stock cementSupplied, Delivery delivery)
        {
            if (cementSupplied != null && delivery != null)
            {
                using (var process = new GetDeliveryConsumedCementSupplied(cementSupplied, delivery))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<DeliveryConsumedCementSupplied> SaveAmountAsync(DeliveryConsumedCementSupplied deliveryConsumedCementSupplied)
        {
            if (deliveryConsumedCementSupplied != null)
            {
                using (var process = new SaveDeliveryConsumedCementSuppliedAmount(deliveryConsumedCementSupplied))
                {
                    deliveryConsumedCementSupplied = await process.ExecuteAsync();
                }
            }

            return deliveryConsumedCementSupplied;
        }
    }
}
