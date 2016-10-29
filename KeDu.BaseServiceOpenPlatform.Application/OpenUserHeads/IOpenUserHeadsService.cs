using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using KeDu.BaseServiceOpenPlatform.OpenUserHeads.Dtos;

namespace KeDu.BaseServiceOpenPlatform.OpenUserHeads
{
    /// <summary>
    /// 开放平台用户标识服务
    /// </summary>
    public interface IOpenUserHeadsService : IApplicationService
    {
        /// <summary>
        /// 获取OpenId
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        GetOpenIdOutput GetOpenId(GetOpenIdInput input);
    }
}
