using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateEmployee : DataProcessBase
    {
        public UpdateEmployee(Employee employee)
        {
            _Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        private Employee _Employee;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand("UpdateEmployee", connection, transaction)
                .AddInParameter("@_Id", _Employee.Id)
                .AddInParameter("@_FirstName", _Employee.FirstName)
                .AddInParameter("@_MiddleName", _Employee.MiddleName)
                .AddInParameter("@_LastName", _Employee.LastName)
                .AddInParameter("@_PositionId", _Employee.Position?.Id)
                .AddInParameter("@_BranchId", _Employee.Branch?.Id)
                .AddInParameter("@_CompanyId", _Employee.Company?.Id)
                .AddInParameter("@_PayrollType", _Employee.PayrollType?.Id)
                .AddInParameter("@_BirthDate", _Employee.BirthDate)
                .AddInParameter("@_CivilStatus", _Employee.CivilStatus.ToString())
                .AddInParameter("@_EmploymentDate", _Employee.EmploymentDate)
                .AddInParameter("@_TIN", _Employee.TIN)
                .AddInParameter("@_Address", _Employee.Address)
                .AddInParameter("@_TelephoneNumber", _Employee.TelephoneNumber)
                .AddInParameter("@_MobileNumber", _Employee.MobileNumber)
                .AddInParameter("@_EmailAddress", _Employee.EmailAddress)
                .AddInParameter("@_EmergencyContactPerson", _Employee.EmergencyContactPerson)
                .AddInParameter("@_EmergencyContactPersonNumber", _Employee.EmergencyContactPersonNumber)
                .AddInParameter("@_EmploymentStatus", _Employee.EmploymentStatus.ToString())
                .AddInParameter("@_SSSNumber", _Employee.SSSNumber)
                .AddInParameter("@_R1ADate", _Employee.R1ADate)
                .AddInParameter("@_PagIbigNumber", _Employee.PagIbigNumber)
                .AddInParameter("@_PhilHealthNumber", _Employee.PhilHealthNumber)
                .AddInParameter("@_PhilHealthRegistrationDate", _Employee.PhilHealthRegistrationDate)
                .AddInParameter("@_PagIbigRTN", _Employee.PagIbigRTN)
                .AddInParameter("@_PagIbigRegistrationDate", _Employee.PagIbigRegistrationDate)
                .AddInParameter("@_PagIbigRTNDependentNumber", _Employee.PagIbigRTNDependentNumber)
                .AddInParameter("@_VacationLeave", _Employee.VacationLeave)
                .AddInParameter("@_SickLeave", _Employee.SickLeave)
                .AddInParameter("@_Absences", _Employee.Absences);
        }

        public override void Dispose()
        {
            _Employee = null;
            base.Dispose();
        }

        public async Task<Employee> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() > 0)
                {
                    await EmployeeAdditionManager.SaveAsync(_Employee.Addition, connection, transaction);
                    await EmployeeDeductionManager.SaveAsync(_Employee.Deduction, connection, transaction);
                    return _Employee;
                }
                else
                {
                    return null;
                }
            }
        }

        public Task<Employee> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
