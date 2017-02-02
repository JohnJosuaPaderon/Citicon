using Citicon.Data;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetPumpTypeList : IDisposable
    {
        private MySqlConnectionHelper ConnectionHelper;

        public GetPumpTypeList()
        {
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<IEnumerable<PumpType>> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetPumpTypeList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<PumpType> pumpTypes = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                pumpTypes = new List<PumpType>();
                                while (await reader.ReadAsync())
                                {
                                    pumpTypes.Add(new PumpType
                                    {
                                        Id = reader.GetUInt64("Id"),
                                        Name = reader.GetString("Name")
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        pumpTypes = null;
                        throw;
                    }
                    return pumpTypes;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
