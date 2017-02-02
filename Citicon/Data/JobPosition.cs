using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public class JobPosition
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
