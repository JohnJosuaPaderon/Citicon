using System.Security;

namespace Citicon.Data
{
    public class SystemUser : EntityBase<ulong>
    {
        public static SystemUser CurrentUser { get; internal set; }
        public SecureString SecureUsername { get; set; }
        public SecureString SecurePassword { get; set; }
        public SystemUserType Type { get; set; }
        public SystemUserStatus Status { get; set; }
    }
}
