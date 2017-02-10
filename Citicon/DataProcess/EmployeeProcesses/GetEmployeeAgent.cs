using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Citicon.DataProcess
{
    public class GetEmployeeAgent : IDisposable
    {
        private MySqlConnectionHelper ConnectionHelper;

        public GetEmployeeAgent()
        {
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public IEnumerable<Employee> Return()
        {
            using (var connection = ConnectionHelper.EstablishConnection())
            {
                using (var command = new MySqlCommand("GetEmployeeAgent", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<Employee> employeeAgents = null;
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                employeeAgents = new List<Employee>();
                                while (reader.Read())
                                {
                                    employeeAgents.Add(new Employee
                                    {
                                        FirstName = reader.GetString("FirstName"),
                                        Id = reader.GetInt64("EmployeeId"),
                                        LastName = reader.GetString("LastName"),
                                        MiddleName = reader.GetString("MiddleName"),
                                        Position = JobPositionManager.GetById(reader.GetInt64("JobPositionId"))
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        employeeAgents = null;
                    }
                    return employeeAgents;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
