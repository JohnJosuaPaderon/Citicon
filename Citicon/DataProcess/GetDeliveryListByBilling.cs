using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetDeliveryListByBilling : DataProcessBase
    {
        public GetDeliveryListByBilling(Billing billing)
        {
            _Billing = billing;
        }

        private readonly Billing _Billing;
        
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetDeliveryListByBilling), connection)
                .AddInParameter("@_BillingId", _Billing.Id);
        }

        private async Task<Delivery> FromReaderAsync(DbDataReader reader)
        {
            return new Delivery
            {
                Billing = _Billing,
                DeliveryReceiptNumber = reader.GetUInt64("DeliveryReceiptNumber"),
                Id = reader.GetUInt64("Id"),
                ProjectDesign = await ProjectDesignManager.GetByIdAsync(reader.GetUInt64("ProjectDesignId")),
                Volume = reader.GetDecimal("Volume")
            };
        }

        public Task<IEnumerable<Delivery>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
