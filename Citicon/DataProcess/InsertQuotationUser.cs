﻿using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class InsertQuotationUser : DataProcessBase
    {
        public InsertQuotationUser(QuotationUser quotationUser)
        {
            QuotationUser = quotationUser;
        }

        private QuotationUser QuotationUser { get; }

        public async Task<QuotationUser> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    try
                    {
                        await ExecuteAsync(connection, transaction);
                        transaction.Commit();
                        return QuotationUser;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public async Task<QuotationUser> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = new MySqlCommand("InsertQuotationUser", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter { ParameterName = "@_Id", Direction = ParameterDirection.Output });
                command.Parameters.AddWithValue("@_Username", Supports.Encrypt(QuotationUser.Username));
                command.Parameters.AddWithValue("@_Password", Supports.Encrypt(QuotationUser.Password));
                command.Parameters.AddWithValue("@_DisplayName", QuotationUser.DisplayName);
                command.Parameters.AddWithValue("@_ModuleId", Module.CurrentModule?.Id);
                command.Parameters.AddWithValue("@_RedirectToFinalApproval", QuotationUser.RedirectToFinalApproval);

                await command.ExecuteNonQueryAsync();
                return QuotationUser;
            }
        }
    }
}
