using System.Reflection;
using Abp.Modules;

namespace KeDu.BaseServiceOpenPlatform
{
    [DependsOn(typeof(BaseServiceOpenPlatformCoreModule))]
    public class BaseServiceOpenPlatformApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //We must declare mappings to be able to use AutoMapper
            DtoMappings.Map();
        }
    }
}
