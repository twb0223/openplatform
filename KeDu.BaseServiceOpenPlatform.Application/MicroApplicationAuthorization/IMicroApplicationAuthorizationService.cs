using Abp.Application.Services;
using KeDu.BaseServiceOpenPlatform.MicroApplicationAuthorization.Dtos;
using System;

namespace KeDu.BaseServiceOpenPlatform.MicroApplicationAuthorization
{
    public interface IMicroApplicationAuthorizationService : IApplicationService
    {
        /// <summary>
        /// 添加授权应用
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Models.MicroApplicationAuthorization AddAuthorization(MicroApplicationAuthorizationDto input);

        /// <summary>
        /// 更新授权应用
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Models.MicroApplicationAuthorization UpdateAuthorization(MicroApplicationAuthorizationDto input);

        /// <summary>
        /// 删除授权应用
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        bool DeleteAuthorization(Guid Id);

    }
}
