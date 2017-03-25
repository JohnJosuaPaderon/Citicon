using System;
using Citicon.Data;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Citicon.DataProcess
{
    public class InsertPumpType : DataProcessBase
    {
        private PumpType PumpType;

        public InsertPumpType(PumpType pumpType)
        {
            PumpType = pumpType;
        }

        public async Task<PumpType> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    using (var command = new MySqlCommand("InsertPumpType", connection, transaction))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter() { ParameterName = "@_Id", Direction = ParameterDirection.Output });
                        command.Parameters.AddWithValue("@_Name", PumpType.Name);
                        try
                        {
                            await command.ExecuteNonQueryAsync();
                            transaction.Commit();
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e.Message);
                            transaction.Rollback();
                            throw;
                        }
                        var paramId = command.Parameters["@_Id"];

                        if (paramId.Value == DBNull.Value)
                        {
                            PumpType.Id = 0;
                        }
                        else
                        {
                            PumpType.Id = Convert.ToUInt64(paramId.Value);
                        }
                        return PumpType;
                    }
                }
            }
        }
    }
}