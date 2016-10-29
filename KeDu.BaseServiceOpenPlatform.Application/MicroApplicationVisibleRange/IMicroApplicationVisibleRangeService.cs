using Abp.Application.Services;
using KeDu.BaseServiceOpenPlatform.MicroApplicationVisibleRange.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeDu.BaseServiceOpenPlatform.MicroApplicationVisibleRange
{
    public interface IMicroApplicationVisibleRangeService : IApplicationService
    {
        /// <summary>
        /// 添加范围
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Models.MicroApplicationVisibleRange AddMicroApplicationVisibleRange(MicroApplicationVisibleRangeDto input);

        /// <summary>
        /// 更新范围
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Models.MicroApplicationVisibleRange UpdateMicroApplicationVisibleRange(MicroApplicationVisibleRangeDto input);

        /// <summary>
        /// 删除范围
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        bool DeleteUpdateMicroApplicationVisibleRange(Guid Id);
    }
}
