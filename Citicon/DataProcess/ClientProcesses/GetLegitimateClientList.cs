using Citicon.Data;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess.ClientProcesses
{
    public sealed class GetLegitimateClientList : IDisposable
    {
        #region Constructor
        public GetLegitimateClientList()
        {
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        MySqlConnectionHelper ConnectionHelper { get; set; }
        #endregion

        #region Helper Methods
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand("GetLegitimateClientList", connection);
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }
        #endregion

        #region Execute
        public async Task<IEnumerable<Client>> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                if (connection.State == ConnectionState.Open)
                {
                    using (var command = CreateCommand(connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                var clients = new List<Client>();

                                while (await reader.ReadAsync())
                                {
                                    clients.Add(new Client
                                    {
                                        Address = reader.GetString("Address"),
                                        CompanyName = reader.GetString("CompanyName"),
                                        //ContactNumber = reader.GetString("ContactNumber"),
                                        //Designation = reader.GetString("Designation"),
                                        //EmailAddress = reader.GetString("EmailAddress"),
                                        //Employee = await EmployeeManager.GetByIdAsync(reader.GetInt64("EmployeeId")),
                                        //FirstName = reader.GetString("FirstName"),
                                        Id = reader.GetUInt64("Id")//,
                                        //LastName = reader.GetString("LastName"),
                                        //Legitimate = reader.GetBoolean("Legitimate"),
                                        //MiddleName = reader.GetString("MiddleName"),
                                        //PhotoPath = reader.GetString("PhotoPath"),
                                        //Position = reader.GetString("Position"),
                                        //PresidentMobileNumber = reader.GetString("PresidentMobileNumber"),
                                        //PresidentName = reader.GetString("PresidentName"),
                                        //PresidentTelephoneNumber = reader.GetString("PresidentTelephoneNumber"),
                                        //Tin = reader.GetString("Tin"),
                                        //Title = reader.GetString("Title")
                                    });
                                }

                                return clients;
                            }
                        }
                    }
                }

                return null;
            }
        }
        #endregion

        #region IDisposable
        public void Dispose()
        {
            ConnectionHelper = null;
        } 
        #endregion
    }
}
