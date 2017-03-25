using System.Configuration;

namespace Citicon.Data
{
    public sealed class Module
    {
        public static Module CurrentModule
        {
            get
            {
                return new Module
                {
                    Code = ConfigurationManager.AppSettings["Module.Code"],
                    Description = ConfigurationManager.AppSettings["Module.Description"],
                    Id = ulong.Parse(ConfigurationManager.AppSettings["Module.Id"])
                };
            }
        }

        public ulong Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public static bool operator ==(Module left, Module right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Module left, Module right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Module)
            {
                return (Module)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
