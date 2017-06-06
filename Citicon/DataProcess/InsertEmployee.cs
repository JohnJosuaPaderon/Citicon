using Citicon.Data;
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
            var command = Utility.CreateProcedureCommand("InsertEmployee", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter(Parameter_Id));
            command.Parameters.AddWithValue("@_FirstName", Employee.FirstName);
            command.Parameters.AddWithValue("@_MiddleName", Employee.MiddleName);
            command.Parameters.AddWithValue("@_LastName", Employee.LastName);
            command.Parameters.AddWithValue("@_PositionId", Employee.Position?.Id);
            command.Parameters.AddWithValue("@_BranchId", Employee.Branch?.Id);
            command.Parameters.AddWithValue("@_CompanyId", Employee.Company?.Id);
            command.Parameters.AddWithValue("@_PayrollType", Employee.PayrollType.ToString());
            command.Parameters.AddWithValue("@_BirthDate", Employee.BirthDate);
            command.Parameters.AddWithValue("@_CivilStatus", Employee.CivilStatus.ToString());
            command.Parameters.AddWithValue("@_EmploymentDate", Employee.EmploymentDate);
            command.Parameters.AddWithValue("@_TIN", Employee.TIN);
            command.Parameters.AddWithValue("@_Address", Employee.Address);
            command.Parameters.AddWithValue("@_TelephoneNumber", Employee.TelephoneNumber);
            command.Parameters.AddWithValue("@_MobileNumber", Employee.MobileNumber);
            command.Parameters.AddWithValue("@_EmailAddress", Employee.EmailAddress);
            command.Parameters.AddWithValue("@_EmergencyContactPerson", Employee.EmergencyContactPerson);
            command.Parameters.AddWithValue("@_EmergencyContactPersonNumber", Employee.EmergencyContactPersonNumber);
            command.Parameters.AddWithValue("@_EmploymentStatus", Employee.EmploymentStatus.ToString());
            command.Parameters.AddWithValue("@_SSSNumber", Employee.SSSNumber);
            command.Parameters.AddWithValue("@_R1ADate", Employee.R1ADate);
            command.Parameters.AddWithValue("@_PagIbigNumber", Employee.PagIbigNumber);
            command.Parameters.AddWithValue("@_PhilHealthNumber", Employee.PhilHealthNumber);
            command.Parameters.AddWithValue("@_PhilHealthRegistrationDate", Employee.PhilHealthRegistrationDate);
            command.Parameters.AddWithValue("@_PagIbigRTN", Employee.PagIbigRTN);
            command.Parameters.AddWithValue("@_PagIbigRegistrationDate", Employee.PagIbigRegistrationDate);
            command.Parameters.AddWithValue("@_PagIbigRTNDependentNumber", Employee.PagIbigRTNDependentNumber);
            command.Parameters.AddWithValue("@_VacationLeave", Employee.VacationLeave);
            command.Parameters.AddWithValue("@_SickLeave", Employee.SickLeave);
            command.Parameters.AddWithValue("@_Absences", Employee.Absences);
            command.Parameters.AddWithValue("@_BasicPay", Employee.BasicPay);
            command.Parameters.AddWithValue("@_DailyRate", Employee.DailyRate);
            command.Parameters.AddWithValue("@_Allowance", Employee.Allowance);
            command.Parameters.AddWithValue("@_OTAllowance", Employee.OTAllowance);
            command.Parameters.AddWithValue("@_SSSDeduction", Employee.SSSDeduction);
            command.Parameters.AddWithValue("@_SSSERDeduction", Employee.SSSERDeduction);
            command.Parameters.AddWithValue("@_SSSECDeduction", Employee.SSSECDeduction);
            command.Parameters.AddWithValue("@_WithHoldingTax", Employee.WithHoldingTax);
            command.Parameters.AddWithValue("@_PagIbigDeduction", Employee.PagIbigDeduction);
            command.Parameters.AddWithValue("@_PhilHealthDeduction", Employee.PhilHealthDeduction);

            return command;
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
