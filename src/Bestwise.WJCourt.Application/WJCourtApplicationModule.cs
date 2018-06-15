using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Bestwise.WJCourt.Authorization;

namespace Bestwise.WJCourt
{
    [DependsOn(
        typeof(WJCourtCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WJCourtApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WJCourtAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WJCourtApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
