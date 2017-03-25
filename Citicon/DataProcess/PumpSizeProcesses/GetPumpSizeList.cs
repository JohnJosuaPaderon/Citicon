using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetPumpSizeList : DataProcessBase
    {
        public async Task<IEnumerable<PumpSize>> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetPumpSizeList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<PumpSize> pumpSizes = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                pumpSizes = new List<PumpSize>();
                                while (await reader.ReadAsync())
                                {
                                    pumpSizes.Add(PumpSizeManager.FromDbDataReader(reader));
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        pumpSizes = null;
                        throw;
                    }
                    return pumpSizes;
                }
            }
        }
    }
}
