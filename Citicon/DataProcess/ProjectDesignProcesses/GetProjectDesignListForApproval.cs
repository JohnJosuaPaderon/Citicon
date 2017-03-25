using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetProjectDesignListForApproval : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand("GetProjectDesignListForApproval", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            return command;
        }

        public async Task<IEnumerable<ProjectDesign>> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
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
    }
}
