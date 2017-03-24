using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class InsertOperationTimeFrame
    {
        #region Constructor
        public InsertOperationTimeFrame(OperationTimeFrame operationTimeFrame)
        {
            OperationTimeFrame = operationTimeFrame;
        }
        #endregion

        #region Properties
        private OperationTimeFrame OperationTimeFrame;
        #endregion

        #region Execution
        public async Task<OperationTimeFrame> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = new MySqlCommand("InsertOperationTimeFrame", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter { ParameterName = "@_Id", Direction = ParameterDirection.Output });
                command.Parameters.AddWithValue("@_Start", OperationTimeFrame.Start);
                command.Parameters.AddWithValue("@_Finish", OperationTimeFrame.Finish);

                await command.ExecuteNonQueryAsync();

                var _id = command.Parameters["@_Id"].Value;

                if (_id != DBNull.Value)
                {
                    OperationTimeFrame.Id = Convert.ToUInt64(_id);
                }

                return OperationTimeFrame;
            }
        }
        #endregion
    }
}
