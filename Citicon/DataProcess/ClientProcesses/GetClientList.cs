using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetClientList : DataProcessBase
    {
        public async Task<IEnumerable<Client>> GetAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetClientList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<Client> clients = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                clients = new List<Client>();
                                while (await reader.ReadAsync())
                                {
                                    clients.Add(new Client
                                    {
                                        //Address = reader.GetString("Address"),
                                        CompanyName = reader.GetString("CompanyName"),
                                        //ContactNumber = reader.GetString("ContactNumber"),
                                        //Designation = reader.GetString("Designation"),
                                        //EmailAddress = reader.GetString("EmailAddress"),
                                        //Employee = await EmployeeManager.GetByIdAsync(reader.GetInt64("EmployeeId")),
                                        //FirstName = reader.GetString("FirstName"),
                                        Id = reader.GetUInt64("Id"),
                                        //LastName = reader.GetString("LastName"),
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
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        clients = null;
                    }
                    return clients;
                }
            }
        }
    }
}
