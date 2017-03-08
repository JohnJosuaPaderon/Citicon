using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetProjectBillingInfo : IDisposable
    {
        private Project Project;
        private MySqlConnectionHelper ConnectionHelper;

        public GetProjectBillingInfo(Project project)
        {
            Project = project;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<ProjectBillingInfo> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetProjectBillingInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ProjectId", Project.Id);
                    ProjectBillingInfo billingInfo = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                await reader.ReadAsync();
                                billingInfo = new ProjectBillingInfo
                                {
                                    Project = Project,
                                    RunningBalance = reader.GetDecimal("RunningBalance"),
                                    TotalAmountPaid = reader.GetDecimal("TotalAmountPaid")
                                };
                            }
                        }
                    }
                    catch (Exception)
                    {
                        billingInfo = null;
                        throw;
                    }
                    return billingInfo;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
