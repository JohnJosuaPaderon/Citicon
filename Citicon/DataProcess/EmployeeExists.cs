using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class EmployeeExists : DataProcessBase
    {
        public EmployeeExists(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        private string FirstName;
        private string MiddleName;
        private string LastName;
        private const string Parameter_FirstName = "@_FirstName";
        private const string Parameter_MiddleName = "@_MiddleName";
        private const string Parameter_LastName = "@_LastName";
        
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand()
            {
                CommandText = $"SELECT EmployeeExists({Parameter_FirstName}, {Parameter_MiddleName}, {Parameter_LastName});",
                Connection = connection
            };
            command.Parameters.AddWithValue(Parameter_FirstName, FirstName);
            command.Parameters.AddWithValue(Parameter_MiddleName, MiddleName);
            command.Parameters.AddWithValue(Parameter_LastName, LastName);

            return command;
        }

        public Task<bool> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, Convert.ToBoolean);
        }
    }
}
