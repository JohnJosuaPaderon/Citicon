using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetCementSuppliedListByProject : DataProcessBase
    {
        public GetCementSuppliedListByProject(Project project)
        {
            Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        private Project Project;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand(nameof(GetCementSuppliedListByProject), connection);
            command.Parameters.AddWithValue("@_ProjectId", Project.Id);

            return command;
        }

        private Stock FromReader(DbDataReader reader)
        {
            return new Stock()
            {
                Id = reader.GetUInt64("Id"),
                AddedStockValue = reader.GetDecimal("AddedStockValue"),
                DeliveryDate = reader.GetDateTime("DeliveryDate")
            };
        }

        public Task<IEnumerable<Stock>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }

        public Task<IEnumerable<Stock>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
