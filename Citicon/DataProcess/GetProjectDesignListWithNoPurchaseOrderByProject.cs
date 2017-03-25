using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetProjectDesignListWithNoPurchaseOrderByProject : DataProcessBase
    {
        public GetProjectDesignListWithNoPurchaseOrderByProject(Project project)
        {
            Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        private Project Project;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand("GetProjectDesignListWithNoPurchaseOrderByProjectId", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@_ProjectId", Project.Id);
            return command;
        }

        private ProjectDesign FromReader(DbDataReader reader)
        {
            return new ProjectDesign
            {
                Aggregate = ProductAggregateManager.GetById(reader.GetInt64("AggregateId")),
                CementFactor = reader.GetDecimal("CementFactor"),
                Id = reader.GetUInt64("Id"),
                MixType = ProjectDesignMixTypeManager.Parse(reader.GetString("MixType")),
                PricePerCubicMeter = reader.GetDecimal("PricePerCubicMeter"),
                Project = Project,
                Psi = reader.GetDecimal("Psi"),
                PurchaseOrder = null,
                Strength = ProductStrengthManager.GetById(reader.GetInt64("StrengthId"))
            };
        }

        internal async Task<List<ProjectDesign>> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        var projectDesignList = new List<ProjectDesign>();

                        while (await reader.ReadAsync())
                        {
                            projectDesignList.Add(FromReader(reader));
                        }

                        return projectDesignList;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public async Task<List<ProjectDesign>> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                if (connection.State == ConnectionState.Open)
                {
                    return await ExecuteAsync(connection);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
