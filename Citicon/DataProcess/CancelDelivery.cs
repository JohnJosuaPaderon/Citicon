using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class CancelDelivery : DataProcessBase
    {
        public CancelDelivery(Delivery delivery, DateTime date, string remarks)
        {
            _Delivery = delivery;
            _Date = date;
            _Remarks = remarks;
        }

        private readonly Delivery _Delivery;
        private readonly DateTime _Date;
        private readonly string _Remarks;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand(nameof(CancelDelivery), connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_DeliveryId", _Delivery.Id)
                .AddInParameter("@_Date", _Date)
                .AddInParameter("@_Remarks", _Remarks);
        }

        private CancelledDelivery Callback(int affectedRows, MySqlCommand command)
        {
            if (affectedRows > 0)
            {
                return new CancelledDelivery
                {
                    Id = command.Parameters.GetUInt64("@_Id"),
                    Delivery = _Delivery,
                    Date = _Date,
                    Remarks = _Remarks
                };
            }
            else
            {
                return null;
            }
        }

        public Task<CancelledDelivery> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(CreateCommand, Callback);
        }
    }
}
