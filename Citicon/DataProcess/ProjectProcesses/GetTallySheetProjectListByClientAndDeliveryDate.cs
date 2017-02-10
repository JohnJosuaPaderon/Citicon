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
    public class GetTallySheetProjectListByClientAndDeliveryDate : IDisposable
    {
        private MySqlConnectionHelper ConnectionHelper;
        private Client Client;
        private DateTime DeliveryDate;

        public GetTallySheetProjectListByClientAndDeliveryDate(Client client, DateTime deliveryDate)
        {
            Client = client;
            DeliveryDate = deliveryDate;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<IEnumerable<Project>> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetTallySheetProjectListByClientIdAndDeliveryDate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ClientId", Client.Id);
                    command.Parameters.AddWithValue("@_DeliveryDate", DeliveryDate);
                    List<Project> projects = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                projects = new List<Project>();
                                while (await reader.ReadAsync())
                                {
                                    projects.Add(new Project
                                    {
                                        Client = Client,
                                        Completed = reader.GetBoolean("Completed"),
                                        Id = reader.GetUInt64("Id"),
                                        InitialCement = reader.GetDouble("InitialCement"),
                                        InitialPayment = reader.GetDecimal("InitialPayment"),
                                        Location = reader.GetString("Location"),
                                        Name = reader.GetString("Name"),
                                        TotalCost = reader.GetDecimal("TotalCost"),
                                        Type = reader.GetString("Type")
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        projects = null;
                        throw;
                    }
                    return projects;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
