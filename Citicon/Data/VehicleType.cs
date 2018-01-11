namespace Citicon.Data
{
    public sealed class VehicleType : EntityBase<ulong>
    {
        static VehicleType()
        {
            TransitMixer = new VehicleType()
            {
                Code = "002",
                Description = "TRANSIT MIXER"
            };
        }

        public static VehicleType TransitMixer { get; }
        
        public string Code { get; set; }
        public string Description { get; set; }
        
        public override string ToString()
        {
            return Description;
        }
    }
}
