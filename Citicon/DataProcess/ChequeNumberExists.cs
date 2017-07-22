using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class ChequeNumberExists : DataProcessBase
    {
        public ChequeNumberExists(uint chequeNumber)
        {
            ChequeNumber = chequeNumber;
        }

        private uint ChequeNumber;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand()
            {
                Connection = connection,
                CommandText = $"SELECT ChequeNumberExists({ChequeNumber});"
            };
            return command;
        }

        public Task<bool> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, Convert.ToBoolean);
        }
    }
}
