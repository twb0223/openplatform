﻿using System;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Castle.Facilities.Logging;

namespace KeDu.BaseServiceOpenPlatform.Web
{
    public class MvcApplication : AbpWebApplication<BaseServiceOpenPlatformWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                            f => f.UseAbpLog4Net().WithConfig("log4net.config")
                        );

            base.Application_Start(sender, e);
        }
    }
}
