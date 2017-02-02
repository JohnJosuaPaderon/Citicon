using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetProductAggregateList
    {
        MySqlConnectionHelper ConnectionHelper;

        public GetProductAggregateList()
        {
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public IEnumerable<ProductAggregate> ExecuteReturn()
        {
            using (var connection = ConnectionHelper.EstablishConnection())
            {
                using (var command = new MySqlCommand("GetProductAggregateList", connection))
                {
                    List<ProductAggregate> aggregates = null;
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                aggregates = new List<ProductAggregate>();
                                while (reader.Read())
                                {
                                    aggregates.Add(new ProductAggregate()
                                    {
                                        Id = reader.GetInt64("AggrID"),
                                        Value = reader.GetString("Aggr")
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        aggregates = null;
                    }
                    return aggregates;
                }
            }
        }
    }
}
