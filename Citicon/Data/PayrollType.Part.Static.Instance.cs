using Citicon.DataManager;

namespace Citicon.Data
{
    partial class PayrollType
    {
        public static PayrollType SemiMonthly
        {
            get
            {
                if (_SemiMonthly == null)
                {
                    _SemiMonthly = PayrollTypeManager.GetById(_SemiMonthlyId);
                }

                return _SemiMonthly;
            }
        }

        public static PayrollType Driver
        {
            get
            {
                if (_Driver == null)
                {
                    _Driver = PayrollTypeManager.GetById(_DriverId);
                }

                return _Driver;
            }
        }

        public static PayrollType SubContractual
        {
            get
            {
                if (_SubContractual == null)
                {
                    _SubContractual = PayrollTypeManager.GetById(_SubContractualId);
                }

                return _SubContractual;
            }
        }

        public static PayrollType Weekly
        {
            get
            {
                if (_Weekly == null)
                {
                    _Weekly = PayrollTypeManager.GetById(_WeeklyId);
                }

                return _Weekly;
            }
        }
    }
}
