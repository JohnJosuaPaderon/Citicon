namespace Citicon.Data
{
    public class TransitMixer : Vehicle
    {
        public double VolumeCapacity { get; set; }
        public Employee DefaultDriver { get; set; }
        public decimal Additionals { get; set; }

        public override string ToString()
        {
            return PhysicalNumber;
        }

        public static TransitMixer FromBase(Vehicle vehicle)
        {
            if (vehicle != null)
            {
                return new TransitMixer()
                {
                    Id = vehicle.Id,
                   Type = vehicle.Type,
                   DefaultDriver = null,
                   PhysicalNumber = vehicle.PhysicalNumber,
                   PlateNumber = vehicle.PlateNumber,
                   VolumeCapacity = 0
                };
            }
            else
            {
                return null;
            }
        }
    }
}
