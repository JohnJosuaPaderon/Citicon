using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public class ProjectBillingInfo
    {
        public Project Project { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public decimal RunningBalance { get; set; }
    }
}
