using Citicon.Data;
using Citicon.DataProcess;
using Citicon.Inventory.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Citicon.Inventory.DataProcess
{
    public class SaveCementSuppliedStockProject : DataProcessBase
    {
        private Stock Stock;
        private Project[] Projects;

        public SaveCementSuppliedStockProject(Stock stock, Project[] projects)
        {
            Stock = stock;
            Projects = projects;
        }

        public async Task ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
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
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
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
    }
}
