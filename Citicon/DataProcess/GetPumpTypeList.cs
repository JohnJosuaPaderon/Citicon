using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetPumpTypeList : DataProcessBase
    {
        public async Task<IEnumerable<PumpType>> GetAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
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
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        pumpTypes = null;
                        throw;
                    }
                    return pumpTypes;
                }
            }
        }
    }
}
