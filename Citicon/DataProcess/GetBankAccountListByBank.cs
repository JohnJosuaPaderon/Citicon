using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetBankAccountListByBank : DataProcessBase
    {
        public GetBankAccountListByBank(Bank bank)
        {
            Bank = bank ?? throw new ArgumentNullException(nameof(bank));
        }

        private Bank Bank;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetBankAccountListByBankId", connection);
            command.Parameters.AddWithValue("@_BankId", Bank.Id);

            return command;
        }

        private BankAccount FromReader(DbDataReader reader)
        {
            return new BankAccount()
            {
                Bank = Bank,
                ChequeNumber = reader.GetUInt32("ChequeNumber"),
                ChequeNumberEnd = reader.GetUInt32("ChequeNumberEnd"),
                ChequeNumberStart = reader.GetUInt32("ChequeNumberStart"),
                Code = reader.GetString("Code"),
                Description = reader.GetString("Description"),
                Id = reader.GetUInt64("Id")
            };
        }

        public Task<IEnumerable<BankAccount>> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                return ProcessUtility.HandleReadingIEnumerableAsync(command, FromReader);
            }
        }

        public Task<IEnumerable<BankAccount>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
