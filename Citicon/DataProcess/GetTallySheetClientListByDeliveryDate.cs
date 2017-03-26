using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetTallySheetClientListByDeliveryDate : DataProcessBase
    {
        private DateTime DeliveryDate;

        public GetTallySheetClientListByDeliveryDate(DateTime deliveryDate)
        {
            DeliveryDate = deliveryDate;
        }

        public async Task<IEnumerable<Client>> GetAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
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
    }
}
