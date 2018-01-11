using System.Configuration;

namespace Citicon.Data
{
    public sealed class Module : EntityBase<ulong>
    {
        public static Module CurrentModule
        {
            get
            {
                return new Module
                {
                    Code = ConfigurationManager.AppSettings["Module.Code"],
                    Description = ConfigurationManager.AppSettings["Module.Description"],
                    Id = ulong.Parse(ConfigurationManager.AppSettings["Module.Id"] ?? "0")
                };
            }
        }
        
        public string Code { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
