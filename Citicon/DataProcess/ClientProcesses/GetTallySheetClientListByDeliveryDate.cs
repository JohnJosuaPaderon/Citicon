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
    public class GetTallySheetClientListByDeliveryDate : IDisposable
    {
        private DateTime DeliveryDate;
        private MySqlConnectionHelper ConnectionHelper;

        public GetTallySheetClientListByDeliveryDate(DateTime deliveryDate)
        {
            DeliveryDate = deliveryDate;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<IEnumerable<Client>> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetTallySheetClientListByDeliveryDate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_DeliveryDate", DeliveryDate);
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
