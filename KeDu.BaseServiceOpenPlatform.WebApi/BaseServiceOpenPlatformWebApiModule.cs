using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace KeDu.BaseServiceOpenPlatform
{
    [DependsOn(typeof(AbpWebApiModule), typeof(BaseServiceOpenPlatformApplicationModule))]
    public class BaseServiceOpenPlatformWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(BaseServiceOpenPlatformApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
