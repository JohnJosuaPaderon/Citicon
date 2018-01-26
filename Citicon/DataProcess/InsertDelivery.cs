using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertDelivery : DataProcessBase
    {
        private const string Parameter_Id = "@_Id";

        public InsertDelivery(Delivery delivery)
        {
            _Delivery = delivery ?? throw new ArgumentNullException(nameof(delivery));
        }

        private readonly Delivery _Delivery;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand("InsertDelivery", connection, transaction)
                .AddOutParameter(Parameter_Id)
                .AddInParameter("@_ProjectId", _Delivery.Project?.Id)
                .AddInParameter("@_ProjectDesignId", _Delivery.ProjectDesign?.Id)
                .AddInParameter("@_DeliveryReceiptNumber", _Delivery.DeliveryReceiptNumber)
                .AddInParameter("@_DeliveryDate", _Delivery.DeliveryDate)
                .AddInParameter("@_Load", _Delivery.Load)
                .AddInParameter("@_PlantLeave", _Delivery.PlantLeave)
                .AddInParameter("@_PlantArrive", _Delivery.PlantArrive)
                .AddInParameter("@_Volume", _Delivery.Volume)
                .AddInParameter("@_PricePerCubicMeter", _Delivery.PricePerCubicMeter)
                .AddInParameter("@_RouteId", _Delivery.Route?.Id)
                .AddInParameter("@_TransitMixerId", _Delivery.TransitMixer?.Id)
                .AddInParameter("@_BranchId", _Delivery.Branch?.Id)
                .AddInParameter("@_DriverId", _Delivery.Driver?.Id)
                .AddInParameter("@_MaxSlump", _Delivery.MaxSlump)
                .AddInParameter("@_ScheduleStatus", (string)_Delivery.ScheduleStatus)
                .AddInParameter("@_PurchaseOrderId", _Delivery.PurchaseOrder?.Id)
                .AddInParameter("@_ServiceEngineerId", _Delivery.ServiceEngineer?.Id)
                .AddInParameter("@_Admixture", _Delivery.Admixture)
                .AddInParameter("@_AdmixtureQuantity", _Delivery.AdmixtureQuantity)
                .AddInParameter("@_CumulativeVolume", _Delivery.CumulativeVolume)
                .AddInParameter("@_LoadCutOffId", _Delivery.LoadCutOff?.Id);
        }

        public Task<Delivery> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        public async Task<Delivery> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    _Delivery.Id = Convert.ToUInt64(command.Parameters[Parameter_Id].Value);
                    return _Delivery;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
