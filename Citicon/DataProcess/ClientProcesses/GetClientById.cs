using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetClientById : IDisposable
    {
        private ulong ClientId;
        private MySqlConnectionHelper ConnectionHelper;

        public GetClientById(ulong clientId)
        {
            ClientId = clientId;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<Client> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
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
                                client = await ClientManager.GetFromDbData      Reader(reader);
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

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
