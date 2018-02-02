namespace Citicon.Data
{
    public sealed partial class PayrollType : EntityBase<ushort>
    {
        static PayrollType()
        {
            _SemiMonthlyId = GetIdFromConfig(nameof(SemiMonthly));
            _DriverId = GetIdFromConfig(nameof(Driver));
            _SubContractualId = GetIdFromConfig(nameof(SubContractual));
            _WeeklyId = GetIdFromConfig(nameof(Weekly));
        }

        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
