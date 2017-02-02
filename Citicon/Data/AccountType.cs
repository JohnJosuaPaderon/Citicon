using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public sealed class AccountType : Sorschia.Data
    {
        private ulong id;
        private string code;
        private string name;
        public ulong Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged(nameof(Id), value);
                }
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                if (code != value)
                {
                    code = value;
                    OnPropertyChanged(nameof(Code), value);
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name), value);
                }
            }
        }
        public static bool operator ==(AccountType x, AccountType y)
        {
            return x?.id == y?.id;  
        }
        public static bool operator !=(AccountType x, AccountType y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is AccountType) ? this == (AccountType)obj : false;
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        public override string ToString()
        {
            return name;
        }
    }
}
