using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Bestwise.WJCourt.Configuration;

namespace Bestwise.WJCourt.Web.Host.Startup
{
    [DependsOn(
       typeof(WJCourtWebCoreModule))]
    public class WJCourtWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WJCourtWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WJCourtWebHostModule).GetAssembly());
        }
    }
}
