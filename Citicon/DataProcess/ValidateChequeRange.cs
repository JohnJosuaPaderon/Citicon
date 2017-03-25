using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class ValidateChequeRange : DataProcessBase
    {
        public ValidateChequeRange(BankAccount bankAccount, UInt32Range chequeNumberRange)
        {
            BankAccount = bankAccount ?? throw new ArgumentNullException(nameof(bankAccount));
            ChequeNumberRange = chequeNumberRange;
        }

        private BankAccount BankAccount;
        private UInt32Range ChequeNumberRange;
        private const string PARAMETER_BANKACCOUNTID = "@_BankAccountId";
        private const string PARAMETER_RANGESTART = "@_RangeStart";
        private const string PARAMETER_RANGEEND = "@_RangeEnd";

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand()
            {
                Connection = connection,
                CommandText = string.Format("SELECT ValidateChequeRange({0}, {1}, {2})", PARAMETER_BANKACCOUNTID, PARAMETER_RANGESTART, PARAMETER_RANGEEND)
            };
            command.Parameters.AddWithValue(PARAMETER_BANKACCOUNTID, BankAccount.Id);
            command.Parameters.AddWithValue(PARAMETER_RANGESTART, ChequeNumberRange.Start);
            command.Parameters.AddWithValue(PARAMETER_RANGEEND, ChequeNumberRange.End);
            
            return command;
        }

        public async Task<bool> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                return Convert.ToBoolean(await command.ExecuteScalarAsync());
            }
        }

        public Task<bool> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
