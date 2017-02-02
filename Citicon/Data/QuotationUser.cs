using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public class QuotationUser : User
    {
        public QuotationUser(User user)
        {
            Id = user.Id;
            Username = user.Username;
            Password = user.Password;
            DisplayName = user.DisplayName;
            Module = user.Module;
        }
        public bool RedirectToFinalApproval { get; set; }
    }
}
