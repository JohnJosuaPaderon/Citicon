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
            var parameter = new MySqlParameter()
            {
                ParameterName = parameterName,
                Direction = ParameterDirection.InputOutput,
                Value = value
            };
            return parameter;
        }

        public MySqlParameter CreateOutParameter(string parameterName)
        {
            var parameter = new MySqlParameter()
            {
                ParameterName = parameterName,
                Direction = ParameterDirection.Output
            };
            return parameter;
        }

        public MySqlCommand CreateProcedureCommand(string storedProcedure, MySqlConnection connection)
        {
            var command = new MySqlCommand()
            {
                CommandText = storedProcedure,
                Connection = connection,
                CommandType = CommandType.StoredProcedure
            };
            return command;
        }

        public MySqlCommand CreateProcedureCommand(string storedProcedure, MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = new MySqlCommand()
            {
                CommandText = storedProcedure,
                Connection = connection,
                Transaction = transaction,
                CommandType = CommandType.StoredProcedure
            };
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
