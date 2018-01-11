using System.Configuration;

namespace Citicon.Data
{
    public sealed class Classification : EntityBase<ulong>
    {
        public struct Codes
        {
            private static string GetCode(string key)
            {
                return ConfigurationManager.AppSettings[$"ClassificationCode.{key}"];
            }
            public static string Aggregate { get { return GetCode("Aggregate"); } }
        }
        
        public string Code { get; set; }
        public string Description { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
