using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.DataProcess
{
    public class GetEmployeeById : DataProcessBase
    {
        private long EmployeeId;

        public GetEmployeeById(long employeeId)
        {
            EmployeeId = employeeId;
            BranchManager = new BranchManager();
            CompanyManager = new CompanyManager();
        }

        private BranchManager BranchManager;
        private CompanyManager CompanyManager;

        public async Task<Employee> GetAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetEmployeeById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_EmployeeId", EmployeeId);
                    Employee employee = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                await reader.ReadAsync();
                                var pos = JobPositionManager.GetById(reader.GetInt64("JobPositionId"));
                                employee = new Employee
                                {
                                    FirstName = reader.GetString("FirstName"),
                                    Id = EmployeeId,
                                    LastName = reader.GetString("LastName"),
                                    MiddleName = reader.GetString("MiddleName"),
                                    Position = pos,
                                    Absences = reader.GetDecimal("Absences"),
                                    Address = reader.GetString("Address"),
                                    BirthDate = reader.GetDateTime("BirthDate"),
                                    Branch = BranchManager.GetById(reader.GetUInt64("BranchId")),
                                    CivilStatus = CivilStatusManager.Parse(reader.GetString("CivilStatus")),
                                    Company = CompanyManager.GetById(reader.GetUInt64("CompanyId")),
                                    EmailAddress = reader.GetString("EmailAddress"),
                                    EmergencyContactPerson = reader.GetString("EmergencyContactPerson"),
                                    EmergencyContactPersonNumber = reader.GetString("EmergencyContactPersonNumber"),
                                    EmploymentDate = reader.GetDateTime("EmploymentDate"),
                                    EmploymentStatus = EmploymentStatusManager.Parse(reader.GetString("EmploymentStatus")),
                                    MobileNumber = reader.GetString("MobileNumber"),
                                    JobPosition = pos,
                                    PagIbigNumber = reader.GetString("PagIbigNumber"),
                                    PagIbigRegistrationDate = reader.GetDateTime("PagIbigRegistrationDate"),
                                    PagIbigRTN = reader.GetString("PagIbigRTN"),
                                    PagIbigRTNDependentNumber = reader.GetUInt32("PagIbigRTNDependentNumber"),
                                    PayrollType = PayrollTypeManager.GetById(reader.GetUInt16("PayrollTypeId")),
                                    PhilHealthNumber = reader.GetString("PhilHealthNumber"),
                                    PhilHealthRegistrationDate = reader.GetDateTime("PhilHealthRegistrationDate"),
                                    R1ADate = reader.GetDateTime("R1ADate"),
                                    SickLeave = reader.GetDecimal("SickLeave"),
                                    SSSNumber = reader.GetString("SSSNumber"),
                                    TelephoneNumber = reader.GetString("TelephoneNumber"),
                                    TIN = reader.GetString("TIN"),
                                    VacationLeave = reader.GetDecimal("VacationLeave"),
                                    ShopRate = reader.GetDecimal("ShopRate")
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Debug.WriteLine(ex.Message);
                        employee = null;
                    }
                    return employee;
                }
            }
        }
    }
}
