using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetProjectDesignListByQuotation : DataProcessBase
    {
        public GetProjectDesignListByQuotation(Quotation quotation)
        {
            Quotation = quotation ?? throw new ArgumentNullException(nameof(quotation));
        }

        private Quotation Quotation;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetProjectDesignListByQuotation", connection);
            command.Parameters.AddWithValue("@_QuotationId", Quotation.Id);

            return command;
        }

        public override void Dispose()
        {
            Quotation = null;
            base.Dispose();
        }

        public Task<IEnumerable<ProjectDesign>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }

        private async Task<ProjectDesign> FromReaderAsync(DbDataReader reader)
        {
            return new ProjectDesign()
            {
                Id = reader.GetUInt64("Id"),
                Project = await ProjectManager.GetByIdAsync(reader.GetUInt64("ProjectId")),
                MixType = ProjectDesignMixTypeManager.Parse(reader.GetString("MixType")),
                Psi = reader.GetDecimal("Psi"),
                Aggregate = ProductAggregateManager.GetById(reader.GetInt64("AggregateId")),
                Strength = ProductStrengthManager.GetById(reader.GetInt64("StrengthId")),
                CementFactor = reader.GetDecimal("CementFactor"),
                PricePerCubicMeter = reader.GetDecimal("PricePerCubicMeter"),
                Quotation = Quotation
            };
        }
    }
}
