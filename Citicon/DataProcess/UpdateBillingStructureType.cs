using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateBillingStructureType : DataProcessBase
    {
        public UpdateBillingStructureType(BillingStructureType structureType)
        {
            _StructureType = structureType;
        }

        private readonly BillingStructureType _StructureType;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand(nameof(UpdateBillingStructureType), connection, transaction)
                .AddInParameter("@_Id", _StructureType.Id)
                .AddInParameter("@_Name", _StructureType.Name);
        }

        public async Task<BillingStructureType> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                await command.ExecuteNonQueryAsync();
                return _StructureType;
            }
        }

        public Task<BillingStructureType> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
