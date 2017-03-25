using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class DeleteEmployee : DataProcessBase, IDisposable
    {
        public DeleteEmployee(Employee employee, string deletedBy)
        {
            DeletedBy = string.IsNullOrWhiteSpace(deletedBy) ? throw new ArgumentException("Value cannot be null or white space.", nameof(deletedBy)) : deletedBy;
            Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        private Employee Employee;
        private string DeletedBy;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("DeleteEmployee", connection, transaction);
            command.Parameters.AddWithValue("@_Id", Employee.Id);
            command.Parameters.AddWithValue("@_DeletedBy", DeletedBy);

            return command;
        }

        public async Task<Employee> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                var affectedRows = await command.ExecuteNonQueryAsync();

                if (affectedRows != 1)
                {
                    Employee = null;
                }

                return Employee;
            }
        }

        public Task<Employee> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        public override void Dispose()
        {
            Employee = null;
            DeletedBy = null;
            base.Dispose();
        }
    }
}
