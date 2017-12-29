using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertEmployee : DataProcessBase
    {
        public InsertEmployee(Employee employee)
        {
            Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        private Employee Employee;
        private const string Parameter_Id = "@_Id";

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand("InsertEmployee", connection, transaction)
                .AddOutParameter(Parameter_Id)
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
                .AddInParameter("@_Absences", Employee.Absences)
                .AddInParameter("@_BasicPay", Employee.BasicPay)
                .AddInParameter("@_DailyRate", Employee.DailyRate)
                .AddInParameter("@_Allowance", Employee.Allowance)
                .AddInParameter("@_OTAllowance", Employee.OTAllowance)
                .AddInParameter("@_WithHoldingTax", Employee.WithHoldingTax);
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
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    Employee.Id = Convert.ToInt64(command.Parameters[Parameter_Id].Value);
                }
                else
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
