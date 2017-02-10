using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetEmployeeById : IDisposable
    {
        private long EmployeeId;
        private MySqlConnectionHelper ConnectionHelper;
        private JobPositionManager JobPositionManager;

        public GetEmployeeById(long employeeId)
        {
            EmployeeId = employeeId;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<Employee> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
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
                    catch (Exception e)
                    {
                        employee = null;
                    }
                    return employee;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
