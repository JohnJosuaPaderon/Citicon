using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Citicon
{
    public sealed class MySqlUtility : RelationalDatabaseUtility
    {
        public MySqlUtility(string connectionString) : base(connectionString)
        {
        }

        public MySqlParameter CreateInOutParameter(string parameterName, object value)
        {
            var parameter = new MySqlParameter();
            parameter.ParameterName = parameterName;
            parameter.Direction = ParameterDirection.InputOutput;
            parameter.Value = value;

            return parameter;
        }

        public MySqlParameter CreateOutParameter(string parameterName)
        {
            var parameter = new MySqlParameter();
            parameter.ParameterName = parameterName;
            parameter.Direction = ParameterDirection.Output;

            return parameter;
        }

        public MySqlCommand CreateProcedureCommand(string storedProcedure, MySqlConnection connection)
        {
            var command = new MySqlCommand();
            command.CommandText = storedProcedure;
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            return command;
        }

        public MySqlCommand CreateProcedureCommand(string storedProcedure, MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = new MySqlCommand();
            command.CommandText = storedProcedure;
            command.Connection = connection;
            command.Transaction = transaction;
            command.CommandType = CommandType.StoredProcedure;

            return command;
        }

        public MySqlConnection EstablishConnection()
        {
            var connection = new MySqlConnection(ConnectionString);

            try
            {
                connection.Open();
            }
            catch (MySqlException)
            {
                connection = null;
            }

            return connection;
        }

        public async Task<MySqlConnection> EstablishConnectionAsync()
        {
            var connection = new MySqlConnection(ConnectionString);

            try
            {
                await connection.OpenAsync();
            }
            catch (MySqlException)
            {
                connection = null;
            }

            return connection;
        }

        public async Task<MySqlConnection> EstablishConnectionAsync(CancellationToken cancellationToken)
        {
            var connection = new MySqlConnection(ConnectionString);

            try
            {
                await connection.OpenAsync(cancellationToken);
            }
            catch (MySqlException)
            {
                connection = null;
            }

            return connection;
        }
    }
}
