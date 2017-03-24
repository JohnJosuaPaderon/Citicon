using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class OperationTimeFrameManager
    {
        static OperationTimeFrameManager()
        {
            OperationTimeFrames = new List<OperationTimeFrame>();
        }

        private static List<OperationTimeFrame> OperationTimeFrames { get; }
        private static OperationTimeFrame Manage(OperationTimeFrame operationTimeFrame)
        {
            if (OperationTimeFrames.Contains(operationTimeFrame))
            {
                var index = OperationTimeFrames.IndexOf(operationTimeFrame);
                OperationTimeFrames[index] = operationTimeFrame;
            }
            else
            {
                OperationTimeFrames.Add(operationTimeFrame);
            }

            return operationTimeFrame;
        }

        #region Insert
        public static async Task<OperationTimeFrame> InsertAsync(OperationTimeFrame operationTimeFrame, MySqlConnection connection, MySqlTransaction transaction)
        {
            var process = new InsertOperationTimeFrame(operationTimeFrame);
            return Manage(await process.ExecuteAsync(connection, transaction));
        }
        #endregion
    }
}
