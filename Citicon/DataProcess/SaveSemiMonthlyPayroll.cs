using Citicon.Data;

namespace Citicon.DataProcess
{
    internal sealed class SaveSemiMonthlyPayroll : SavePayrollBase<SemiMonthlyPayroll>
    {
        public SaveSemiMonthlyPayroll(SemiMonthlyPayroll payroll) : base(payroll)
        {
        }
    }
}
