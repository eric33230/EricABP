using Abp.Authorization;
using EricABP.Authorization.Roles;
using EricABP.Authorization.Users;

namespace EricABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
