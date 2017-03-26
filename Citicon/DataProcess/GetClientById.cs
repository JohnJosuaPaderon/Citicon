using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetClientById : DataProcessBase
    {
        private ulong ClientId;

        public GetClientById(ulong clientId)
        {
            ClientId = clientId;
        }

        public async Task<Client> GetAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetClientById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ClientId", ClientId);
                    Client client = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                await reader.ReadAsync();
                                client = await ClientManager.GetFromDbDataReader(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        client = null;
                        throw;
                    }
                    return client;
                }
            }
        }
    }
}
