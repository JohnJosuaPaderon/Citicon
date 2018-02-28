using Citicon.Data;
using Citicon.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetClientCredit : DataProcessBase
    {
        public GetClientCredit(Client client)
        {
            _Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        private readonly Client _Client;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return new MySqlCommand
            {
                CommandText = $"SELECT Credit FROM tblclientdetails WHERE ClientId = {_Client.Id}",
                Connection = connection
            };
        }

        public Task<decimal> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, DbValueConverter.ToDecimal);
        }
    }
}
