using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using KeDu.BaseServiceOpenPlatform.EntityFramework;

namespace KeDu.BaseServiceOpenPlatform
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(BaseServiceOpenPlatformCoreModule))]
    public class BaseServiceOpenPlatformDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<BaseServiceOpenPlatformDbContext>(null);
        }
    }
}
