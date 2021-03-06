﻿using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;

namespace Citicon.DataProcess
{
    public class GetProductAggregateById : DataProcessBase
    {
        long Id;

        public GetProductAggregateById(long id)
        {
            Id = id;
        }

        public ProductAggregate Return()
        {
            using (var connection = Utility.EstablishConnection())
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
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        aggregate = null;
                    }
                    return aggregate;
                }
            }
        }
    }
}
