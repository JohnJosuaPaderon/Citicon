using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetClientMetaDataListWithQuotationForApproval : DataProcessBase
    {
        public async Task<IEnumerable<Client>> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetClientMetaDataListWithQuotationForApproval", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<Client> clients = null;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            clients = new List<Client>();
                            while (await reader.ReadAsync())
                            {
                                clients.Add(new Client()
                                {
                                    Id = reader.GetUInt64("Id"),
                                    CompanyName = reader.GetString("CompanyName"),
                                    Address = reader.GetString("Address")
                                });
                            }
                        }
                    }
                    
                    return clients;
                }
            }
        }
    }
}
