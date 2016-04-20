using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public sealed class Module : Sorschia.Data
    {
        public static Module CurrentModule
        {
            get
            {
                return new Module
                {
                    code = ConfigurationManager.AppSettings["Module.Code"],
                    description = ConfigurationManager.AppSettings["Module.Description"],
                    id = ulong.Parse(ConfigurationManager.AppSettings["Module.Id"])
                };
            }
        }
        private ulong id;
        private string code;
        private string description;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Module.Id", value);
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                code = value;
                OnPropertyChanged("Module.Code", value);
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Module.Description", value);
            }
        }
        public static bool operator ==(Module x, Module y)
        {
            return
                x?.code == y?.code &&
                x?.description == y?.description;
        }
        public static bool operator !=(Module x, Module y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is Module) ? (obj as Module).id == id : false;
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        public override string ToString()
        {
            return description;
        }
    }
}
