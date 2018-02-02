using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Citicon.DataProcess
{
    internal sealed class GetPayrollTypeById : DataProcessBase
    {
        public GetPayrollTypeById(ushort payrollTypeId)
        {
            _PayrollTypeId = payrollTypeId;
        }

        private readonly ushort _PayrollTypeId;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetPayrollTypeById), connection)
                .AddInParameter("@_Id", _PayrollTypeId);
        }

        private PayrollType FromReader(DbDataReader reader)
        {
            return new PayrollType
            {
                Id = _PayrollTypeId,
                Description = reader.GetString("Description")
            };
        }

        public PayrollType Execute()
        {
            return ProcessUtility.HandleReading(CreateCommand, FromReader);
        }
    }
}
