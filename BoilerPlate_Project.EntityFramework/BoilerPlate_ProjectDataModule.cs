using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using BoilerPlate_Project.EntityFramework;

namespace BoilerPlate_Project
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(BoilerPlate_ProjectCoreModule))]
    public class BoilerPlate_ProjectDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BoilerPlate_ProjectDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
