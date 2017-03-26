using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class UpdatePumpType : DataProcessBase
    {
        private PumpType PumpType;

        public UpdatePumpType(PumpType pumpType)
        {
            PumpType = pumpType;
        }

        public async Task<PumpType> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    using (var command = new MySqlCommand("UpdatePumpType", connection, transaction))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@_Id", PumpType.Id);
                        command.Parameters.AddWithValue("@_Name", PumpType.Name);
                        try
                        {
                            await command.ExecuteNonQueryAsync();
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                            transaction.Rollback();
                            throw;
                        }
                        return PumpType;
                    }
                }
            }
        }
    }
}
