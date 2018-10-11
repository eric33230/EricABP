using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EricABP.Authorization;

namespace EricABP
{
    [DependsOn(
        typeof(EricABPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EricABPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EricABPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EricABPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
