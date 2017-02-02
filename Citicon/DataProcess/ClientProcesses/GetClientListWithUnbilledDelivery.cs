using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetClientListWithUnbilledDelivery : IDisposable
    {
        public GetClientListWithUnbilledDelivery()
        {
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        private MySqlConnectionHelper ConnectionHelper;

        public async Task<IEnumerable<Client>> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetClientListWithUnbilledDelivery", connection))
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
                                    clients.Add(await ClientManager.GetFromDbDataReader(reader));
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

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
