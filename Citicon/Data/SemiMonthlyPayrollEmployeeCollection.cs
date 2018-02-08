using System;
using System.Collections;
using System.Collections.Generic;

namespace Citicon.Data
{
    public sealed class SemiMonthlyPayrollEmployeeCollection : IEnumerable<SemiMonthlyPayrollEmployee>
    {
        public SemiMonthlyPayrollEmployeeCollection(IEnumerable<SemiMonthlyPayrollEmployee> source)
        {
            _Source = source ?? throw new ArgumentNullException(nameof(source));
            Computed = false;
        }

        private readonly IEnumerable<SemiMonthlyPayrollEmployee> _Source;

        private bool Computed;

        private decimal _TotalDailyRate;
        private decimal _TotalBasicPay;
        private decimal _TotalAllowance;
        private decimal _TotalOvertimeAllowance;
        private decimal _TotalWithholdingTax;
        private decimal _TotalSss;
        private decimal _TotalSssEr;
        private decimal _TotalSssEc;
        private decimal _TotalPagibig;
        private decimal _TotalPhilHealth;
        private decimal _TotalCashAdvance;
        private decimal _TotalSunCellBill;
        private decimal _TotalRegularOvetimePay;
        private decimal _TotalSundayPay;
        private decimal _TotalSpecialHolidayPay;
        private decimal _TotalSpecialHolidayOvertimePay;
        private decimal _TotalGrossPay;
        private decimal _TotalDeduction;
        private decimal _TotalNetPay;

        public decimal TotalDailyRate
        {
            get
            {
                TryCompute();
                return _TotalDailyRate;
            }
        }

        public decimal TotalBasicPay
        {
            get
            {
                TryCompute();
                return _TotalBasicPay;
            }
        }

        public decimal TotalAllowance
        {
            get
            {
                TryCompute();
                return _TotalAllowance;
            }
        }

        public decimal TotalOvertimeAllowance
        {
            get
            {
                TryCompute();
                return _TotalOvertimeAllowance;
            }
        }

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

        public decimal TotalRegularOvertimePay
        {
            get
            {
                TryCompute();
                return _TotalRegularOvetimePay;
            }
        }

        public decimal TotalSundayPay
        {
            get
            {
                TryCompute();
                return _TotalSundayPay;
            }
        }

        public decimal TotalSpecialHolidayPay
        {
            get
            {
                TryCompute();
                return _TotalSpecialHolidayPay;
            }
        }

        public decimal TotalSpecialHolidayOvertimePay
        {
            get
            {
                TryCompute();
                return _TotalSpecialHolidayOvertimePay;
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
                    _TotalDailyRate += payrollEmployee.DailyRate;
                    _TotalBasicPay += payrollEmployee.BasicPay;
                    _TotalAllowance += payrollEmployee.Allowance;
                    _TotalOvertimeAllowance += payrollEmployee.OvertimeAllowance;
                    _TotalWithholdingTax += payrollEmployee.WithholdingTax;
                    _TotalSss += payrollEmployee.Sss;
                    _TotalSssEr += payrollEmployee.SssEr;
                    _TotalSssEc += payrollEmployee.SssEc;
                    _TotalPagibig += payrollEmployee.Pagibig;
                    _TotalPhilHealth += payrollEmployee.PhilHealth;
                    _TotalCashAdvance += payrollEmployee.CashAdvance;
                    _TotalSunCellBill += payrollEmployee.SunCellBill;
                    _TotalRegularOvetimePay += payrollEmployee.RegularOvertimePay;
                    _TotalSundayPay += payrollEmployee.SundayPay;
                    _TotalSpecialHolidayPay += payrollEmployee.SpecialHolidayPay;
                    _TotalSpecialHolidayOvertimePay += payrollEmployee.SpecialHolidayOvertimePay;
                    _TotalGrossPay += payrollEmployee.GrossPay;
                    _TotalDeduction += payrollEmployee.TotalDeduction;
                    _TotalNetPay += payrollEmployee.NetPay;
                }

                Computed = true;
            }
        }

        public IEnumerator<SemiMonthlyPayrollEmployee> GetEnumerator()
        {
            return _Source.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Source.GetEnumerator();
        }
    }
}
