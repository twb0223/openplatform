using Abp.Web.Mvc.Controllers;

namespace KeDu.BaseServiceOpenPlatform.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class BaseServiceOpenPlatformControllerBase : AbpController
    {
        protected BaseServiceOpenPlatformControllerBase()
        {
            LocalizationSourceName = BaseServiceOpenPlatformConsts.LocalizationSourceName;
        }
    }
}