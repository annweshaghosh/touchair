using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using BoilerPlate_Project.EntityFramework;

namespace BoilerPlate_Project.Migrator
{
    [DependsOn(typeof(BoilerPlate_ProjectDataModule))]
    public class BoilerPlate_ProjectMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<BoilerPlate_ProjectDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}