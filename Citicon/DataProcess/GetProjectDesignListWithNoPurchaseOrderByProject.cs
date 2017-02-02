using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetProjectDesignListWithNoPurchaseOrderByProject : IDisposable
    {
        #region Constructor
        public GetProjectDesignListWithNoPurchaseOrderByProject(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException(nameof(project));
            }

            Project = project;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private Project Project;
        private MySqlConnectionHelper ConnectionHelper;
        #endregion

        #region Helpers
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand("GetProjectDesignListWithNoPurchaseOrderByProjectId", connection);
            command.CommandType = CommandType.StoredProcedure;
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
        #endregion

        #region Executions
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
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
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
        #endregion

        #region IDisposable
        public void Dispose()
        {
            ConnectionHelper = null;
        } 
        #endregion
    }
}
