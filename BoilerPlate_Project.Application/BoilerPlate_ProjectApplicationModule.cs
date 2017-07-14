using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace BoilerPlate_Project
{
    [DependsOn(typeof(BoilerPlate_ProjectCoreModule), typeof(AbpAutoMapperModule))]
    public class BoilerPlate_ProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
