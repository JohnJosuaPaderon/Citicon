using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetApprovedProjectDesignListByProject : DataProcessBase
    {
        public GetApprovedProjectDesignListByProject(Project project)
        {
            Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        private Project Project;

        public override void Dispose()
        {
            Project = null;
            base.Dispose();
        }

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetApprovedProjectDesignListByProject", connection);
            command.Parameters.AddWithValue("@_ProjectId", Project.Id);

            return command;
        }
        
        public Task<IEnumerable<ProjectDesign>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand(connection), FromReader);
        }

        public Task<IEnumerable<ProjectDesign>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        private ProjectDesign FromReader(DbDataReader reader)
        {
            return new ProjectDesign()
            {
                Id = reader.GetUInt64("Id"),
                PricePerCubicMeter = reader.GetDecimal("PricePerCubicMeter"),
                InitialVolume = reader.GetDecimal("InitialVolume"),
                MixType = ProjectDesignMixTypeManager.Parse(reader.GetString("MixType")),
                Psi = reader.GetDecimal("Psi"),
                Aggregate = ProductAggregateManager.GetById(reader.GetInt64("AggregateId")),
                Strength = ProductStrengthManager.GetById(reader.GetInt64("StrengthId")),
                CementFactor = reader.GetDecimal("CementFactor"),
                ForApproval = false,
                Project = Project,
                PurchaseOrder = PurchaseOrderManager.GetById(reader.GetUInt64("PurchaseOrderId"))
            };
        }
    }
}
