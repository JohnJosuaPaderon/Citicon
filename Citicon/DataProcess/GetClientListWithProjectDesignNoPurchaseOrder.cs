using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetClientListWithProjectDesignNoPurchaseOrder : IDisposable
    {
        #region Constructor
        public GetClientListWithProjectDesignNoPurchaseOrder()
        {
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private MySqlConnectionHelper ConnectionHelper;
        #endregion

        #region Helpers
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand("GetClientListWithProjectDesignNoPurchaseOrderId", connection);
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }

        private Client FromReader(DbDataReader reader)
        {
            return new Client
            {
                CompanyName = reader.GetString("CompanyName"),
                Id = reader.GetUInt64("Id")
            };
        }
        #endregion

        #region Executions
        internal async Task<List<Client>> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        var clientList = new List<Client>();

                        while (await reader.ReadAsync())
                        {
                            clientList.Add(FromReader(reader));
                        }

                        return clientList;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public async Task<List<Client>> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                if (connection.State == ConnectionState.Open)
                {
                    return await ExecuteAsync(connection);
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        #region IDisposable
        public void Dispose()
        {
            ConnectionHelper = null;
        } 
        #endregion
    }
}
