using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetEmployeeById : DataProcessBase
    {
        private long EmployeeId;

        public GetEmployeeById(long employeeId)
        {
            EmployeeId = employeeId;
        }

        public async Task<Employee> GetAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetEmployeeById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_EmployeeId", EmployeeId);
                    Employee employee = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                await reader.ReadAsync();
                                employee = new Employee
                                {
                                    FirstName = reader.GetString("FirstName"),
                                    Id = EmployeeId,
                                    LastName = reader.GetString("LastName"),
                                    MiddleName = reader.GetString("MiddleName"),
                                    Position = JobPositionManager.GetById(reader.GetInt64("JobPositionId"))
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        employee = null;
                    }
                    return employee;
                }
            }
        }
    }
}
