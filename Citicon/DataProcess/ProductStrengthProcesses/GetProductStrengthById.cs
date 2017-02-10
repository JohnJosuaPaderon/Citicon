using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Citicon.DataProcess
{
    public class GetProductStrengthById
    {
        long Id;
        MySqlConnectionHelper ConnectionHelper;

        public GetProductStrengthById(long id)
        {
            Id = id;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public ProductStrength Return()
        {
            using (var connection = ConnectionHelper.EstablishConnection())
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
                    catch (Exception e)
                    {
                        strength = null;
                    }
                    return strength;
                }
            }
        }
    }
}
