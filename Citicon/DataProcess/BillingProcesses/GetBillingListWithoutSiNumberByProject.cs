using Citicon.Data;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetBillingListWithoutSiNumberByProject : IDisposable
    {
        private Project Project;
        private MySqlConnectionHelper ConnectionHelper;

        public GetBillingListWithoutSiNumberByProject(Project project)
        {
            Project = project;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<IEnumerable<Billing>> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetBillingListWithoutSiNumberByProjectId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ProjectId", Project.Id);
                    List<Billing> billings = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                billings = new List<Billing>();
                                while (await reader.ReadAsync())
                                {
                                    billings.Add(new Billing
                                    {
                                        Id = reader.GetUInt64("Id"),
                                        AmountDue = reader.GetDecimal("AmountDue"),
                                        BillingNo = reader.GetString("BillingNo"),
                                        SiNumber = reader.GetString("SiNumber"),
                                        Volume = reader.GetDecimal("Volume")
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        billings = null;
                    }
                    return billings;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
