using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetUnbilledDeliveryListByProject : DataProcessBase
    {
        public GetUnbilledDeliveryListByProject(Project project)
        {
            Project = project;
        }

        private Project Project;

        public async Task<IEnumerable<Delivery>> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetUnbilledDeliveryListByProjectId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ProjectId", Project.Id);
                    List<Delivery> deliveries = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                deliveries = new List<Delivery>();
                                while (await reader.ReadAsync())
                                {
                                    deliveries.Add(await DeliveryManager.FromDbDataReader(reader));
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        deliveries = null;
                        throw;
                    }
                    return deliveries;
                }
            }
        }
    }
}
