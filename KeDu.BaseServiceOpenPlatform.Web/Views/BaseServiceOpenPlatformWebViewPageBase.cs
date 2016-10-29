using Abp.Web.Mvc.Views;

namespace KeDu.BaseServiceOpenPlatform.Web.Views
{
    public abstract class BaseServiceOpenPlatformWebViewPageBase : BaseServiceOpenPlatformWebViewPageBase<dynamic>
    {

    }

    public abstract class BaseServiceOpenPlatformWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BaseServiceOpenPlatformWebViewPageBase()
        {
            LocalizationSourceName = BaseServiceOpenPlatformConsts.LocalizationSourceName;
        }
    }
}