using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class InsertUser : DataProcessBase
    {
        public InsertUser(User user)
        {
            User = user;
        }

        private User User { get; }

        public async Task<User> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using ( var transaction = await connection.BeginTransactionAsync())
                {
                    try
                    {
                        await ExecuteAsync(connection, transaction);
                        return User;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public async Task<User> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = new MySqlCommand("InsertUser", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter { ParameterName = "@_Id", Direction = ParameterDirection.Output });
                command.Parameters.AddWithValue("@_Username", Supports.Encrypt(User.Username));
                command.Parameters.AddWithValue("@_Password", Supports.Encrypt(User.Password));
                command.Parameters.AddWithValue("@_DisplayName", User.DisplayName);
                command.Parameters.AddWithValue("@_ModuleId", Module.CurrentModule?.Id);

                await command.ExecuteNonQueryAsync();
                User.Id = Convert.ToUInt64(command.Parameters["@_Id"].Value);
                return User;
            }
        }
    }
}
