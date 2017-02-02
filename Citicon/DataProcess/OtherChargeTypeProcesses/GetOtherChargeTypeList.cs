using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess.OtherChargeTypeProcesses
{
    public sealed class GetOtherChargeTypeList : IDisposable
    {
        #region Constructor
        public GetOtherChargeTypeList()
        {
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private MySqlConnectionHelper ConnectionHelper;
        #endregion

        #region Execution
        public async Task<IEnumerable<OtherChargeType>> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetOtherChargeTypeList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<OtherChargeType> otherChargeTypeList = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                otherChargeTypeList = new List<OtherChargeType>();
                                while (await reader.ReadAsync())
                                {
                                    otherChargeTypeList.Add(OtherChargeTypeManager.FromDbDataReader(reader));
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        otherChargeTypeList = null;
                        throw;
                    }
                    return otherChargeTypeList;
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
