using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;

namespace Citicon.DataProcess
{
    public class GetProductStrengthById : DataProcessBase
    {
        long Id;

        public GetProductStrengthById(long id)
        {
            Id = id;
        }

        public ProductStrength Return()
        {
            using (var connection = Utility.EstablishConnection())
            {
                using (var command = new MySqlCommand("GetProductStrengthById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_StrengthId", Id);
                    ProductStrength strength = null;
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                strength = new ProductStrength()
                                {
                                    Id = Id,
                                    Value = reader.GetString("StrDays")
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        strength = null;
                    }
                    return strength;
                }
            }
        }
    }
}
