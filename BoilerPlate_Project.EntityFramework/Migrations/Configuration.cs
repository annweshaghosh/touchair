using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using BoilerPlate_Project.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace BoilerPlate_Project.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<BoilerPlate_Project.EntityFramework.BoilerPlate_ProjectDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BoilerPlate_Project";
        }

        protected override void Seed(BoilerPlate_Project.EntityFramework.BoilerPlate_ProjectDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
