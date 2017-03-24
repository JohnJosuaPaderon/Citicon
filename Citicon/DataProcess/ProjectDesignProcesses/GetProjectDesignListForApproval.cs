using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetProjectDesignListForApproval : IDisposable
    {
        #region Constructor
        public GetProjectDesignListForApproval()
        {
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private MySqlConnectionHelper ConnectionHelper { get; set; }
        #endregion

        #region Helper Methods
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand("GetProjectDesignListForApproval", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            return command;
        }
        #endregion

        #region Execute
        public async Task<IEnumerable<ProjectDesign>> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                if (connection.State == ConnectionState.Open)
                {
                    using (var command = CreateCommand(connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                var projectDesigns = new List<ProjectDesign>();
                                while (await reader.ReadAsync())
                                {
                                    projectDesigns.Add(new ProjectDesign()
                                    {
                                       Aggregate = ProductAggregateManager.GetById(reader.GetInt64("AggregateId")),
                                       CementFactor = reader.GetDecimal("CementFactor"),
                                       ForApproval = true,
                                       Id = reader.GetUInt64("Id"),
                                       InitialVolume = 0,
                                       MixType = ProjectDesignMixTypeManager.Parse(reader.GetString("MixType")),
                                       PricePerCubicMeter = reader.GetDecimal("PricePerCubicMeter"),
                                       Project = await ProjectManager.GetByIdAsync(reader.GetUInt64("ProjectId")),
                                       Psi = reader.GetDecimal("Psi"),
                                       Strength = ProductStrengthManager.GetById(reader.GetInt64("StrengthId")) 
                                    });
                                }
                                return projectDesigns;
                            }
                        }
                    } 
                }
                return null;
            }
        }
        #endregion

        #region IDisposable
        public void Dispose()
        {
            ConnectionHelper = null;
        } 
        #endregion
    }
}
