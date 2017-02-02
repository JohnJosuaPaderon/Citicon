using Citicon.Data;
using Citicon.Inventory.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Inventory.DataProcess
{
    public class SaveCementSuppliedStockProject : IDisposable
    {
        private Stock Stock;
        private Project[] Projects;
        private MySqlConnectionHelper ConnectionHelper;

        public SaveCementSuppliedStockProject(Stock stock, Project[] projects)
        {
            Stock = stock;
            Projects = projects;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    try
                    {
                        foreach (Project project in Projects)
                        {
                            await ExecuteSingleAsync(project, connection, transaction);
                        }
                        transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        private async Task ExecuteSingleAsync(Project project, MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = new MySqlCommand("SaveCementSuppliedStock", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@_CementSuppliedStockId", Stock.Id);
                command.Parameters.AddWithValue("@_ProjectId", project.Id);
                await command.ExecuteNonQueryAsync();
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
