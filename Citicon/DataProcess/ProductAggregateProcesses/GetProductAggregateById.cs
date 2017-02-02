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
    public class GetProductAggregateById
    {
        long Id;
        MySqlConnectionHelper ConnectionHelper;

        public GetProductAggregateById(long id)
        {
            Id = id;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public ProductAggregate Return()
        {
            using (var connection = ConnectionHelper.EstablishConnection())
            {
                using (var command = new MySqlCommand("GetProductAggregateById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_AggregateId", Id);
                    ProductAggregate aggregate = null;
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                aggregate = new ProductAggregate()
                                {
                                    Id = Id,
                                    Value = reader.GetString("Aggr")
                                };
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        aggregate = null;
                    }
                    return aggregate;
                }
            }
        }
    }
}
