using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;

namespace Citicon.DataProcess
{
    public class GetDepartmentById : IDisposable
    {
        private long Id;
        private MySqlConnectionHelper ConnectionHelper;

        public GetDepartmentById(long id)
        {
            Id = id;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public Department Return()
        {
            using (var connection = ConnectionHelper.EstablishConnection())
            {
                using (var command = new MySqlCommand("GetDepartmentById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_DepartmentId", Id);
                    Department department = null;
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                department = new Department
                                {
                                    Id = Id,
                                    Name = reader.GetString("Name")
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        department = null;
                    }
                    return department;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
