using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;

namespace Citicon.DataProcess
{
    public class GetJobPositionById : IDisposable
    {
        private long Id;
        private MySqlConnectionHelper ConnectionHelper;

        public GetJobPositionById(long id)
        {
            Id = id;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public JobPosition Return()
        {
            using (var connection = ConnectionHelper.EstablishConnection())
            {
                using (var command = new MySqlCommand("GetJobPositionById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_JobPositionId", Id);
                    JobPosition jobPosition = null;
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                jobPosition = new JobPosition
                                {
                                    Department = DepartmentManager.GetById(reader.GetInt64("DepartmentId")),
                                    Id = Id,
                                    Name = reader.GetString("Name")
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        jobPosition = null;
                    }
                    return jobPosition;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
