using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Citicon.DataProcess
{
    public class GetEmployeeAgent : DataProcessBase
    {
        public IEnumerable<Employee> Return()
        {
            using (var connection = Utility.EstablishConnection())
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
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        employeeAgents = null;
                    }
                    return employeeAgents;
                }
            }
        }
    }
}
