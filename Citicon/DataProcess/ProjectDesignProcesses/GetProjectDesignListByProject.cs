using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess.ProjectDesignProcesses
{
    public sealed class GetProjectDesignListByProject : IDisposable
    {
        #region Constructor
        public GetProjectDesignListByProject(Project project)
        {
            Project = project;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private Project Project { get; }
        private MySqlConnectionHelper ConnectionHelper { get; set; }
        #endregion

        #region Execute
        public async Task<IEnumerable<ProjectDesign>> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
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
        #endregion

        #region IDisposable
        public void Dispose()
        {
            ConnectionHelper = null;
        } 
        #endregion
    }
}
