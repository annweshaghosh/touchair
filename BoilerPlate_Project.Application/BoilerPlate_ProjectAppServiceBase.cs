using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using BoilerPlate_Project.MultiTenancy;
using BoilerPlate_Project.Users;
using Microsoft.AspNet.Identity;

namespace BoilerPlate_Project
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BoilerPlate_ProjectAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected BoilerPlate_ProjectAppServiceBase()
        {
            LocalizationSourceName = BoilerPlate_ProjectConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}