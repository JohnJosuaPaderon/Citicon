using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetProjectDesignListByProject : DataProcessBase
    {
        public GetProjectDesignListByProject(Project project)
        {
            Project = project;
        }

        private Project Project { get; }

        public async Task<IEnumerable<ProjectDesign>> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetProjectDesignListByProjectId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ProjectId", Project.Id);

                    List<ProjectDesign> projectDesigns = null;
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            projectDesigns = new List<ProjectDesign>();
                            while (await reader.ReadAsync())
                            {
                                projectDesigns.Add(new ProjectDesign()
                                {
                                    Id = reader.GetUInt64("Id"),
                                    Psi = reader.GetDecimal("Psi"),
                                    MixType = ProjectDesignMixTypeManager.Parse(reader.GetString("MixType")),
                                    Aggregate = ProductAggregateManager.GetById(reader.GetInt64("AggregateId")),
                                    Strength = ProductStrengthManager.GetById(reader.GetInt64("StrengthId")),
                                    CementFactor = reader.GetDecimal("CementFactor"),
                                    PricePerCubicMeter = reader.GetDecimal("PricePerCubicMeter"),
                                    Project = Project
                                });
                            }
                        }
                    }
                    return projectDesigns;
                }
            }
        }
    }
}
