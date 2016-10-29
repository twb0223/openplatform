using Abp.Application.Services;

namespace KeDu.BaseServiceOpenPlatform
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BaseServiceOpenPlatformAppServiceBase : ApplicationService
    {
        protected BaseServiceOpenPlatformAppServiceBase()
        {
            LocalizationSourceName = BaseServiceOpenPlatformConsts.LocalizationSourceName;
        }
    }
}