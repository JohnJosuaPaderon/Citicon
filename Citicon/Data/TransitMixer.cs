namespace Citicon.Data
{
    public class TransitMixer : Vehicle
    {
        public double VolumeCapacity { get; set; }

        public override string ToString()
        {
            return PhysicalNumber;
        }
    }
}
