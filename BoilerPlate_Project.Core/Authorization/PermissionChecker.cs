using Abp.Authorization;
using BoilerPlate_Project.Authorization.Roles;
using BoilerPlate_Project.MultiTenancy;
using BoilerPlate_Project.Users;

namespace BoilerPlate_Project.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
