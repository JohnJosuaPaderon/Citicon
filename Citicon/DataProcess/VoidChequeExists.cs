using Citicon.Data;
using Citicon.Utilities;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class VoidChequeExists : DataProcessBase
    {
        public VoidChequeExists(string chequeNumber, BankAccount bankAccount)
        {
            _ChequeNumber = chequeNumber;
            _BankAccount = bankAccount;
        }

        private readonly string _ChequeNumber;
        private readonly BankAccount _BankAccount;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return new MySqlCommand($"SELECT IsVoidChequeExists('{_ChequeNumber}', {_BankAccount?.Id})", connection);
        }

        public Task<bool> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, DbValueConverter.ToBoolean);
        }
    }
}
