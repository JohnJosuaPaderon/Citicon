using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertBillingStructureType : DataProcessBase
    {
        public InsertBillingStructureType(BillingStructureType structureType)
        {
            _StructureType = structureType;
        }

        private readonly BillingStructureType _StructureType;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand(nameof(InsertBillingStructureType), connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_Name", _StructureType.Name);
        }

        public async Task<BillingStructureType> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                await command.ExecuteNonQueryAsync();
                _StructureType.Id = command.Parameters.GetUInt64("@_Id");

                return _StructureType;
            }
        }

        public Task<BillingStructureType> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
