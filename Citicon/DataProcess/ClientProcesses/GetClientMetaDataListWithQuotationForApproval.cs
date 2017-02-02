using Citicon.Data;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess.ClientProcesses
{
    public sealed class GetClientMetaDataListWithQuotationForApproval : IDisposable
    {
        #region Constructor
        public GetClientMetaDataListWithQuotationForApproval()
        {
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private MySqlConnectionHelper ConnectionHelper;
        #endregion

        public async Task<IEnumerable<Client>> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
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

        #region IDisposable
        public void Dispose()
        {
            ConnectionHelper = null;
        } 
        #endregion
    }
}
