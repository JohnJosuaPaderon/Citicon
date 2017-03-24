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
    public sealed class GetAccessoryTypeList : IDisposable
    {
        #region Constructor
        public GetAccessoryTypeList()
        {
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private MySqlConnectionHelper ConnectionHelper;
        #endregion

        #region Execution
        public async Task<IEnumerable<AccessoryType>> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetAccessoryTypeList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<AccessoryType> accessoryTypes = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                accessoryTypes = new List<AccessoryType>();
                                while (await reader.ReadAsync())
                                {
                                    accessoryTypes.Add(AccessoryTypeManager.FromDbDataReader(reader));
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        accessoryTypes = null;
                        throw;
                    }
                    return accessoryTypes;
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
