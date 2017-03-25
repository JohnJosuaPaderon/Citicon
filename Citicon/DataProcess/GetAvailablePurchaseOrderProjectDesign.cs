using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetAvailablePurchaseOrderProjectDesign : DataProcessBase
    {
        public GetAvailablePurchaseOrderProjectDesign(ProjectDesign projectDesign)
        {
            ProjectDesign = projectDesign ?? throw new ArgumentNullException(nameof(projectDesign));
        }

        private ProjectDesign ProjectDesign;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetAvailablePurchaseOrderProjectDesign", connection);
            command.Parameters.AddWithValue("@_ProjectDesignId", ProjectDesign.Id);

            return command;
        }

        public override void Dispose()
        {
            ProjectDesign = null;
            base.Dispose();
        }


        public Task<PurchaseOrderProjectDesign> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand(connection), FromReader);
        }

        public Task<PurchaseOrderProjectDesign> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        private PurchaseOrderProjectDesign FromReader(DbDataReader reader)
        {
            return new PurchaseOrderProjectDesign()
            {
                PurchaseOrder = PurchaseOrderManager.GetById(reader.GetUInt64("PurchaseOrderId")),
                ProjectDesign = ProjectDesign,
                MaxVolume = reader.GetDecimal("MaxVolume"),
                ConsumedVolume = reader.GetDecimal("ConsumedVolume")
            };
        }
    }
}
