﻿using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Citicon.DataProcess
{
    public class GetProductStrengthList : DataProcessBase
    {
        public IEnumerable<ProductStrength> ExecuteReturn()
        {
            using (var connection = Utility.EstablishConnection())
            {
                using (var command = new MySqlCommand("GetProductStrengthList", connection))
                {
                    List<ProductStrength> strengths = null;
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                strengths = new List<ProductStrength>();
                                while (reader.Read())
                                {
                                    strengths.Add(new ProductStrength()
                                    {
                                        Id = reader.GetInt64("StrID"),
                                        Value = reader.GetString("StrDays")
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        strengths = null;
                    }
                    return strengths;
                }
            }
        }
    }
}
