using MySql.Data.MySqlClient;
using System.Data;

namespace Citicon.Extensions
{
    public static class MySqlCommandExtension
    {
        public static MySqlCommand AddParameter(this MySqlCommand instance, ParameterDirection direction, string name, object value)
        {
            instance.Parameters.Add(new MySqlParameter
            {
                ParameterName = name,
                Direction = direction,
                Value = value
            });

            return instance;
        }

        public static MySqlCommand AddInParameter(this MySqlCommand instance, string name, object value)
        {
            return instance.AddParameter(ParameterDirection.Input, name, value);
        }

        public static MySqlCommand AddInOutParameter(this MySqlCommand instance, string name, object value)
        {
            return instance.AddParameter(ParameterDirection.InputOutput, name, value);
        }

        public static MySqlCommand AddOutParameter(this MySqlCommand instance, string name)
        {
            return instance.AddParameter(ParameterDirection.Output, name, null);
        }
    }
}
