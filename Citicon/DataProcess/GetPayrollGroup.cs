using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Citicon.DataProcess
{
    internal sealed class GetPayrollGroup : DataProcessBase
    {
        public GetPayrollGroup(ushort payrollGroupId)
        {
            _PayrollGroupId = payrollGroupId;
        }

        private readonly ushort _PayrollGroupId;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetPayrollGroup), connection)
                .AddInParameter("@_Id", _PayrollGroupId);
        }

        private PayrollGroup FromReader(DbDataReader reader)
        {
            return new PayrollGroup
            {
                Id = _PayrollGroupId,
                Description = reader.GetString("Description")
            };
        }

        public PayrollGroup Execute()
        {
            return ProcessUtility.HandleReading(CreateCommand, FromReader);
        }
    }
}
