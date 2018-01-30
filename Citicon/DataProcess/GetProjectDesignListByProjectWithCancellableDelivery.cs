using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetProjectDesignListByProjectWithCancellableDelivery : DataProcessBase
    {
        public GetProjectDesignListByProjectWithCancellableDelivery(Project project)
        {
            _Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        private readonly Project _Project;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetProjectDesignListByProjectWithCancellableDelivery), connection)
                .AddInParameter("@_ProjectId", _Project.Id);
        }

        private async Task<ProjectDesign> FromReaderAsync(DbDataReader reader)
        {
            return new ProjectDesign
            {
                Aggregate = ProductAggregateManager.GetById(reader.GetInt64("AggregateId")),
                CementFactor = reader.GetDecimal("CementFactor"),
                ForApproval = default(bool),
                Id = reader.GetUInt64("Id"),
                InitialVolume = default(decimal),
                MixType = ProjectDesignMixTypeManager.Parse(reader.GetString("MixType")),
                PricePerCubicMeter = reader.GetDecimal("PricePerCubicMeter"),
                Project = _Project,
                Psi = reader.GetDecimal("Psi"),
                PurchaseOrder = default(PurchaseOrder),
                Quotation = await QuotationManager.GetByIdAsync(reader.GetUInt64("QuotationId")),
                Strength = ProductStrengthManager.GetById(reader.GetInt64("StrengthId"))
            };
        }

        public Task<IEnumerable<ProjectDesign>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
