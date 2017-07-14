using System.Linq;
using BoilerPlate_Project.EntityFramework;
using BoilerPlate_Project.MultiTenancy;

namespace BoilerPlate_Project.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly BoilerPlate_ProjectDbContext _context;

        public DefaultTenantCreator(BoilerPlate_ProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
