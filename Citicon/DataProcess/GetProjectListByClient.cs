using Citicon.Data;
using Citicon.Data.Converters;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetProjectListByClient : DataProcessBase
    {
        private Client Client;

        public GetProjectListByClient(Client client)
        {
            Client = client;
        }

        public async Task<IEnumerable<Project>> GetAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetProjectListByClientId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ClientId", Client.Id);
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
                                        Type = ProjectTypeConverter.Parse(reader.GetString("Type")),
                                        QuotationType = QuotationTypeConverter.Parse(reader.GetString("QuotationType"))
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        projects = null;
                    }
                    return projects;
                }
            }
        }
    }
}
