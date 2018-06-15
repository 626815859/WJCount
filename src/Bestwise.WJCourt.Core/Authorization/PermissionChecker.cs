using Abp.Authorization;
using Bestwise.WJCourt.Authorization.Roles;
using Bestwise.WJCourt.Authorization.Users;

namespace Bestwise.WJCourt.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
