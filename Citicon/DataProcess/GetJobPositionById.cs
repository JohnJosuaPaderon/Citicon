using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;

namespace Citicon.DataProcess
{
    public class GetJobPositionById : DataProcessBase
    {
        private long Id;

        public GetJobPositionById(long id)
        {
            Id = id;
        }

        public JobPosition Return()
        {
            using (var connection = Utility.EstablishConnection())
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
    }
}
