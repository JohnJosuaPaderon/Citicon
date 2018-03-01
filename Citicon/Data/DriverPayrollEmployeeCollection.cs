using System;
using System.Collections;
using System.Collections.Generic;

namespace Citicon.Data
{
    public sealed class DriverPayrollEmployeeCollection : IEnumerable<DriverPayrollEmployee>
    {
        public DriverPayrollEmployeeCollection(IEnumerable<DriverPayrollEmployee> source)
        {
            _Source = source ?? throw new ArgumentNullException(nameof(source));
            Computed = false;
        }

        private readonly IEnumerable<DriverPayrollEmployee> _Source;

        private bool Computed;
        
        private decimal _TotalWithholdingTax;
        private decimal _TotalSss;
        private decimal _TotalSssEr;
        private decimal _TotalSssEc;
        private decimal _TotalPagibig;
        private decimal _TotalPhilHealth;
        private decimal _TotalCashAdvance;
        private decimal _TotalSunCellBill;
        private decimal _TotalGrossPay;
        private decimal _TotalDeduction;
        private decimal _TotalNetPay;

        public decimal TotalWithholdingTax
        {
            get
            {
                TryCompute();
                return _TotalWithholdingTax;
            }
        }

        public decimal TotalSss
        {
            get
            {
                TryCompute();
                return _TotalSss;
            }
        }

        public decimal TotalSssEr
        {
            get
            {
                TryCompute();
                return _TotalSssEr;
            }
        }

        public decimal TotalSssEc
        {
            get
            {
                TryCompute();
                return _TotalSssEc;
            }
        }

        public decimal TotalPagibig
        {
            get
            {
                TryCompute();
                return _TotalPagibig;
            }
        }

        public decimal TotalPhilHealth
        {
            get
            {
                TryCompute();
                return _TotalPhilHealth;
            }
        }

        public decimal TotalCashAdvance
        {
            get
            {
                TryCompute();
                return _TotalCashAdvance;
            }
        }

        public decimal TotalSunCellBill
        {
            get
            {
                TryCompute();
                return _TotalSunCellBill;
            }
        }

        public decimal TotalGrossPay
        {
            get
            {
                TryCompute();
                return _TotalGrossPay;
            }
        }

        public decimal TotalDeduction
        {
            get
            {
                TryCompute();
                return _TotalDeduction;
            }
        }

        public decimal TotalNetPay
        {
            get
            {
                TryCompute();
                return _TotalNetPay;
            }
        }

        private void TryCompute()
        {
            if (!Computed)
            {
                foreach (var payrollEmployee in _Source)
                {
                    _TotalWithholdingTax += payrollEmployee.WithholdingTax;
                    _TotalSss += payrollEmployee.Sss;
                    _TotalSssEr += payrollEmployee.SssEr;
                    _TotalSssEc += payrollEmployee.SssEc;
                    _TotalPagibig += payrollEmployee.Pagibig;
                    _TotalPhilHealth += payrollEmployee.PhilHealth;
                    _TotalCashAdvance += payrollEmployee.CashAdvance;
                    _TotalSunCellBill += payrollEmployee.SunCellBill;
                    _TotalGrossPay += payrollEmployee.GrossPay;
                    _TotalDeduction += payrollEmployee.TotalDeduction;
                    _TotalNetPay += payrollEmployee.NetPay;
                }

                Computed = true;
            }
        }

        public IEnumerator<DriverPayrollEmployee> GetEnumerator()
        {
            return _Source.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Source.GetEnumerator();
        }
    }
}
