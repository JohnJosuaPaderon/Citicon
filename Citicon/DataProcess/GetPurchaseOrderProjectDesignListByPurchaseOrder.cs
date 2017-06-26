using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetPurchaseOrderProjectDesignListByPurchaseOrder : DataProcessBase
    {
        public GetPurchaseOrderProjectDesignListByPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            PurchaseOrder = purchaseOrder ?? throw new ArgumentNullException(nameof(purchaseOrder));
        }

        private PurchaseOrder PurchaseOrder;

        public override void Dispose()
        {
            PurchaseOrder = null;
            base.Dispose();
        }

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetPurchaseOrderProjectDesignListByPurchaseOrderId", connection);
            command.Parameters.AddWithValue("@_PurchaseOrderId", PurchaseOrder?.Id);
            return command;
        }

        private async Task<PurchaseOrderProjectDesign> FromReaderAsync(DbDataReader reader)
        {
            return new PurchaseOrderProjectDesign()
            {
                ConsumedVolume = reader.GetDecimal("ConsumedVolume"),
                MaxVolume = reader.GetDecimal("MaximumVolume"),
                ProjectDesign = await ProjectDesignManager.GetByIdAsync(reader.GetUInt64("ProjectDesignId")),
                PurchaseOrder = PurchaseOrder
            };
        }

        public Task<IEnumerable<PurchaseOrderProjectDesign>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
