namespace Citicon.Data
{
    public class Vehicle : EntityBase<ulong>
    {
        public VehicleType Type { get; set; }
        public string PhysicalNumber { get; set; }
        public string PlateNumber { get; set; }
        
        public override string ToString()
        {
            return $"{PhysicalNumber} / {PlateNumber}";
        }
    }
}
