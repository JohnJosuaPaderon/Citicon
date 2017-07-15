using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetProjectDesignListWithDelivery : DataProcessBase
    {
        public GetProjectDesignListWithDelivery(DateTime deliveryDate)
        {
            DeliveryDate = deliveryDate;
        }

        private DateTime DeliveryDate;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetProjectDesignListWithDelivery", connection);
            command.Parameters.AddWithValue("@_DeliveryDate", DeliveryDate);

            return command;
        }

        public Task<IEnumerable<ProjectDesign>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }

        private async Task<ProjectDesign> FromReaderAsync(DbDataReader reader)
        {
            return new ProjectDesign()
            {
                Aggregate = ProductAggregateManager.GetById(reader.GetInt64("AggregateId")),
                CementFactor = reader.GetDecimal("CementFactor"),
                Id = reader.GetUInt64("Id"),
                MixType = ProjectDesignMixTypeManager.Parse(reader.GetString("MixType")),
                PricePerCubicMeter = reader.GetDecimal("PricePerCubicMeter"),
                Project = await ProjectManager.GetByIdAsync(reader.GetUInt64("ProjectId")),
                Psi = reader.GetDecimal("Psi"),
                Strength = ProductStrengthManager.GetById(reader.GetInt64("StrengthId"))
            };
        }
    }
}
