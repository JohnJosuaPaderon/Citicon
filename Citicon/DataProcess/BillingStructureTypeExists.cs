using Citicon.Data;
using Citicon.Utilities;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class BillingStructureTypeExists : DataProcessBase
    {
        public BillingStructureTypeExists(BillingStructureType structureType)
        {
            _StructureType = structureType;
        }

        private readonly BillingStructureType _StructureType;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return new MySqlCommand($"SELECT {nameof(BillingStructureTypeExists)}({_StructureType.Id}, '{_StructureType.Name}');", connection);
        }

        public Task<bool> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, DbValueConverter.ToBoolean);
        }
    }
}
