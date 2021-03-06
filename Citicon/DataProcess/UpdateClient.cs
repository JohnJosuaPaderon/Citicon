﻿using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateClient : DataProcessBase
    {
        public UpdateClient(Client client)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        private Client Client;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("UpdateClient", connection, transaction);
            command.Parameters.AddWithValue("@_Id", Client.Id);
            command.Parameters.AddWithValue("@_CompanyName", Client.CompanyName);
            command.Parameters.AddWithValue("@_Address", Client.Address);
            command.Parameters.AddWithValue("@_EmailAddress", Client.EmailAddress);
            command.Parameters.AddWithValue("@_ContactNumber", Client.ContactNumber);
            command.Parameters.AddWithValue("@_TIN", Client.Tin);
            command.Parameters.AddWithValue("@_Position", Client.Position);
            command.Parameters.AddWithValue("@_Title", Client.Title);
            command.Parameters.AddWithValue("@_FirstName", Client.FirstName);
            command.Parameters.AddWithValue("@_LastName", Client.LastName);
            command.Parameters.AddWithValue("@_PresidentName", Client.PresidentName);
            command.Parameters.AddWithValue("@_PresidentTelephoneNumber", Client.PresidentTelephoneNumber);
            command.Parameters.AddWithValue("@_PresidentMobileNumber", Client.PresidentMobileNumber);
            command.Parameters.AddWithValue("@_Designation", Client.Designation);
            command.Parameters.AddWithValue("@_Legitimate", Client.Legitimate);

            return command;
        }

        public override void Dispose()
        {
            Client = null;
            base.Dispose();
        }

        public async Task<Client> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() != 1)
                {
                    Client = null;
                }

                return Client;
            }
        }

        public Task<Client> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
