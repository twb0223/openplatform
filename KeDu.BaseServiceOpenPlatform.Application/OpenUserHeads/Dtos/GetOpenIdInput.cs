using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeDu.BaseServiceOpenPlatform.OpenUserHeads.Dtos
{
    /// <summary>
    /// 获取OpenId输入参数
    /// </summary>
    public class GetOpenIdInput
    {
        /// <summary>
        /// 嘟嘟用户Id
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 微应用Id
        /// </summary>
        public Guid OpenPlatformMicroApplicationId { get; set; }
    }
}
