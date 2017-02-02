using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetProductListByProjectId
    {
        MySqlConnectionHelper ConnectionHelper;
        Project Project;
        public GetProductListByProjectId(Project project)
        {
            Project = project;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public IEnumerable<ProjectDesign> Return()
        {
            using (var connection = ConnectionHelper.EstablishConnection())
            {
                using (var command = new MySqlCommand("GetProductListByProjectId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ProjectId", Project.Id);
                    List<ProjectDesign> products = null;
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                products = new List<ProjectDesign>();
                                while (reader.Read())
                                {
                                    products.Add(new ProjectDesign()
                                    {
                                        Aggregate = ProductAggregateManager.GetById(reader.GetInt64("AggregateId")),
                                        MixType = (ProjectDesignMixType)Enum.Parse(typeof(ProjectDesignMixType), reader.GetString("DesignMixType")),
                                        Id = reader.GetUInt64("ProjectDesignID"),
                                        InitialVolume = reader.GetInt32("InitialVolume"),
                                        PricePerCubicMeter = reader.GetDecimal("PricePerCubic"),
                                        Project = Project,
                                        Psi = reader.GetDecimal("PSI"),
                                        //Remarks = reader.GetString("Remarks"),
                                        Strength = ProductStrengthManager.GetById(reader.GetInt64("StrengthId"))
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        products = null;
                    }
                    return products;
                }
            }
        }
    }
}
