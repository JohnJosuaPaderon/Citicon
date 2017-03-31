using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetProjectDesignListByProjectAndDeliveryDate : DataProcessBase
    {
        public GetProjectDesignListByProjectAndDeliveryDate(Project project, DateTime deliveryDate)
        {
            Project = project ?? throw new ArgumentNullException(nameof(project));
            DeliveryDate = deliveryDate;
        }

        private Project Project;
        private DateTime DeliveryDate;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetProjectDesignListByProjectAndDeliveryDate", connection);
            command.Parameters.AddWithValue("@_ProjectId", Project.Id);
            command.Parameters.AddWithValue("@_DeliveryDate", DeliveryDate);

            return command;
        }

        public override void Dispose()
        {
            Project = null;
            base.Dispose();
        }

        public Task<IEnumerable<ProjectDesign>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }

        private ProjectDesign FromReader(DbDataReader reader)
        {
            return new ProjectDesign()
            {
                Aggregate = ProductAggregateManager.GetById(reader.GetInt64("AggregateId")),
                CementFactor = reader.GetDecimal("CementFactor"),
                Id = reader.GetUInt64("Id"),
                MixType = ProjectDesignMixTypeManager.Parse(reader.GetString("MixType")),
                PricePerCubicMeter = reader.GetDecimal("PricePerCubicMeter"),
                Project = Project,
                Psi = reader.GetDecimal("Psi"),
                Strength = ProductStrengthManager.GetById(reader.GetInt64("StrengthId")),
            };
        }
    }
}
