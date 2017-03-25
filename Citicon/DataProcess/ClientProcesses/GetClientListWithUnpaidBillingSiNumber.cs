using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetClientListWithUnpaidBillingSiNumber : DataProcessBase
    {
        public async Task<IEnumerable<Client>> GetAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetClientListWithUnpaidBillingSiNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<Client> clients = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                clients = new List<Client>();
                                while (await reader.ReadAsync())
                                {
                                    clients.Add(new Client
                                    {
                                        Address = reader.GetString("Address"),
                                        CompanyName = reader.GetString("CompanyName"),
                                        Id = reader.GetUInt64("Id")
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        clients = null;
                        throw;
                    }
                    return clients;
                }
            }
        }
    }
}
