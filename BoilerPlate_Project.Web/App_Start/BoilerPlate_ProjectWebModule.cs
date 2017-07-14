using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Hangfire;
using Abp.Hangfire.Configuration;
using Abp.Modules;
using Abp.Web.Mvc;
using Abp.Web.SignalR;
using Abp.Zero.Configuration;
using BoilerPlate_Project.Api;
using Hangfire;

namespace BoilerPlate_Project.Web
{
    [DependsOn(
        typeof(BoilerPlate_ProjectDataModule),
        typeof(BoilerPlate_ProjectApplicationModule),
        typeof(BoilerPlate_ProjectWebApiModule),
        typeof(AbpWebSignalRModule),
        //typeof(AbpHangfireModule), - ENABLE TO USE HANGFIRE INSTEAD OF DEFAULT JOB MANAGER
        typeof(AbpWebMvcModule))]
    public class BoilerPlate_ProjectWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Enable database based localization
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<BoilerPlate_ProjectNavigationProvider>();

            //Configure Hangfire - ENABLE TO USE HANGFIRE INSTEAD OF DEFAULT JOB MANAGER
            //Configuration.BackgroundJobs.UseHangfire(configuration =>
            //{
            //    configuration.GlobalConfiguration.UseSqlServerStorage("Default");
            //});
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
