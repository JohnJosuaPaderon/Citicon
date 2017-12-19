using System.Collections;
using System.Collections.Generic;

namespace Citicon.Data
{
    public sealed class EmployeePayrollCollection : IEnumerable<EmployeePayroll>
    {
        public EmployeePayrollCollection(Payroll payroll)
        {
            Payroll = payroll;
        }

        private readonly Dictionary<Employee, EmployeePayroll> _Source;
        
        public Payroll Payroll { get; }

        public EmployeePayroll this[Employee employee]
        {
            get
            {
                if (employee != null && _Source.ContainsKey(employee))
                {
                    return _Source[employee];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (employee != null && _Source.ContainsKey(employee))
                {
                    value.Payroll = Payroll;
                    _Source[employee] = value;
                }
            }
        }

        public void Add(EmployeePayroll employeePayroll)
        {
            if (employeePayroll != null && !_Source.ContainsKey(employeePayroll.Employee))
            {
                employeePayroll.Payroll = Payroll;
                _Source.Add(employeePayroll.Employee, employeePayroll);
            }
        }

        private bool Remove(EmployeePayroll employeePayroll)
        {
            if (employeePayroll != null)
            {
                employeePayroll.Payroll = null;
                return _Source.Remove(employeePayroll.Employee);
            }
            else
            {
                return false;
            }
        }

        public IEnumerator<EmployeePayroll> GetEnumerator()
        {
            return _Source.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
