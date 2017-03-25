using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class MySqlDataProcessUtility
    {
        public MySqlDataProcessUtility(string connectionString)
        {
            Utility = new MySqlUtility(connectionString);
        }

        private MySqlUtility Utility { get; }

        public TResult HandleExecute<TResult>(Func<MySqlConnection, MySqlTransaction, TResult> function)
        {
            using (var connection = Utility.EstablishConnection())
            {
                if (Utility.IsConnectionNotNullAndOpen(connection))
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            var output = function(connection, transaction);
                            transaction.Commit();
                            return output;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                else
                {
                    return default(TResult);
                }
            }
        }

        public TResult HandleExecute<TResult>(Func<MySqlConnection, TResult> function)
        {
            using (var connection = Utility.EstablishConnection())
            {
                if (Utility.IsConnectionNotNullAndOpen(connection))
                {
                    return function(connection);
                }
                else
                {
                    return default(TResult);
                }
            }
        }

        public async Task<TResult> HandleExecuteAsync<TResult>(Func<MySqlConnection, MySqlTransaction, Task<TResult>> functionAsync)
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                if (Utility.IsConnectionNotNullAndOpen(connection))
                {
                    using (var transaction = await connection.BeginTransactionAsync())
                    {
                        try
                        {
                            var output = await functionAsync(connection, transaction);
                            transaction.Commit();
                            return output;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                else
                {
                    return default(TResult);
                }
            }
        }

        public async Task<TResult> HandleExecuteAsync<TResult>(Func<MySqlConnection, Task<TResult>> functionAsync)
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                if (Utility.IsConnectionNotNullAndOpen(connection))
                {
                    return await functionAsync(connection);
                }
                else
                {
                    return default(TResult);
                }
            }
        }

        public TResult HandleReading<TResult>(MySqlCommand command, Func<DbDataReader, TResult> fromReader)
        {
            using (command)
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return fromReader(reader);
                    }
                    else
                    {
                        return default(TResult);
                    }
                }
            }
        }

        public async Task<TResult> HandleReadingAsync<TResult>(MySqlCommand command, Func<DbDataReader, Task<TResult>> fromReaderAsync)
        {
            using (command)
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        await reader.ReadAsync();
                        return await fromReaderAsync(reader);
                    }
                    else
                    {
                        return default(TResult);
                    }
                }
            }
        }

        public async Task<TResult> HandleReadingAsync<TResult>(MySqlCommand command, Func<DbDataReader, TResult> fromReader)
        {
            using (command)
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        await reader.ReadAsync();
                        return fromReader(reader);
                    }
                    else
                    {
                        return default(TResult);
                    }
                }
            }
        }

        public async Task<IEnumerable<TResult>> HandleReadingIEnumerableAsync<TResult>(MySqlCommand command, Func<DbDataReader, Task<TResult>> fromReaderAsync)
        {
            using (command)
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        var list = new List<TResult>();

                        while (await reader.ReadAsync())
                        {
                            list.Add(await fromReaderAsync(reader));
                        }

                        return list;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public async Task<IEnumerable<TResult>> HandleReadingIEnumerableAsync<TResult>(MySqlCommand command, Func<DbDataReader, TResult> fromReader)
        {
            using (command)
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        var list = new List<TResult>();

                        while (await reader.ReadAsync())
                        {
                            list.Add(fromReader(reader));
                        }

                        return list;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public Task<IEnumerable<TResult>> HandleReadingIEnumerableAsync<TResult>(Func<MySqlConnection, MySqlCommand> createCommand, Func<DbDataReader, TResult> fromReader)
        {
            return HandleExecuteAsync((c) =>
            {
                return HandleReadingIEnumerableAsync(createCommand(c), fromReader);
            });
        }

        public Task<IEnumerable<TResult>> HandleReadingIEnumerableAsync<TResult>(Func<MySqlConnection, MySqlCommand> createCommand, Func<DbDataReader, Task<TResult>> fromReaderAsync)
        {
            return HandleExecuteAsync((c) =>
            {
                return HandleReadingIEnumerableAsync(createCommand(c), fromReaderAsync);
            });
        }

        public Task<TResult> HandleReadingAsync<TResult>(Func<MySqlConnection, MySqlCommand> createCommand, Func<DbDataReader, TResult> fromReader)
        {
            return HandleExecuteAsync((c) =>
            {
                return HandleReadingAsync(createCommand(c), fromReader);
            });
        }

        public TResult HandleReading<TResult>(Func<MySqlConnection, MySqlCommand> createCommand, Func<DbDataReader, TResult> fromReader)
        {
            return HandleExecute((c) =>
            {
                return HandleReading(createCommand(c), fromReader);
            });
        }

        public Task<TResult> HandleReadingAsync<TResult>(Func<MySqlConnection, MySqlCommand> createCommand, Func<DbDataReader, Task<TResult>> fromReaderAsync)
        {
            return HandleExecuteAsync((c) =>
            {
                return HandleReadingAsync(createCommand(c), fromReaderAsync);
            });
        }

    }
}
