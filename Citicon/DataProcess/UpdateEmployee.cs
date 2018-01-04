using Citicon.Data;
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
            Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        private Employee Employee;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand("UpdateEmployee", connection, transaction)
                .AddInParameter("@_Id", Employee.Id)
                .AddInParameter("@_FirstName", Employee.FirstName)
                .AddInParameter("@_MiddleName", Employee.MiddleName)
                .AddInParameter("@_LastName", Employee.LastName)
                .AddInParameter("@_PositionId", Employee.Position?.Id)
                .AddInParameter("@_BranchId", Employee.Branch?.Id)
                .AddInParameter("@_CompanyId", Employee.Company?.Id)
                .AddInParameter("@_PayrollType", Employee.PayrollType.ToString())
                .AddInParameter("@_BirthDate", Employee.BirthDate)
                .AddInParameter("@_CivilStatus", Employee.CivilStatus.ToString())
                .AddInParameter("@_EmploymentDate", Employee.EmploymentDate)
                .AddInParameter("@_TIN", Employee.TIN)
                .AddInParameter("@_Address", Employee.Address)
                .AddInParameter("@_TelephoneNumber", Employee.TelephoneNumber)
                .AddInParameter("@_MobileNumber", Employee.MobileNumber)
                .AddInParameter("@_EmailAddress", Employee.EmailAddress)
                .AddInParameter("@_EmergencyContactPerson", Employee.EmergencyContactPerson)
                .AddInParameter("@_EmergencyContactPersonNumber", Employee.EmergencyContactPersonNumber)
                .AddInParameter("@_EmploymentStatus", Employee.EmploymentStatus.ToString())
                .AddInParameter("@_SSSNumber", Employee.SSSNumber)
                .AddInParameter("@_R1ADate", Employee.R1ADate)
                .AddInParameter("@_PagIbigNumber", Employee.PagIbigNumber)
                .AddInParameter("@_PhilHealthNumber", Employee.PhilHealthNumber)
                .AddInParameter("@_PhilHealthRegistrationDate", Employee.PhilHealthRegistrationDate)
                .AddInParameter("@_PagIbigRTN", Employee.PagIbigRTN)
                .AddInParameter("@_PagIbigRegistrationDate", Employee.PagIbigRegistrationDate)
                .AddInParameter("@_PagIbigRTNDependentNumber", Employee.PagIbigRTNDependentNumber)
                .AddInParameter("@_VacationLeave", Employee.VacationLeave)
                .AddInParameter("@_SickLeave", Employee.SickLeave)
                .AddInParameter("@_Absences", Employee.Absences);
        }

        public override void Dispose()
        {
            Employee = null;
            base.Dispose();
        }

        public async Task<Employee> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() != 1)
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
    }
}
