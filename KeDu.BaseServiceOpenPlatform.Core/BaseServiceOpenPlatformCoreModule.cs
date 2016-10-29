using System.Reflection;
using Abp.Modules;

namespace KeDu.BaseServiceOpenPlatform
{
    public class BaseServiceOpenPlatformCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
