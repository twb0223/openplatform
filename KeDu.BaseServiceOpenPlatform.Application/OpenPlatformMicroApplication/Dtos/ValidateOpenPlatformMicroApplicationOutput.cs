using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeDu.BaseServiceOpenPlatform.OpenPlatformMicroApplication.Dtos
{
    /// <summary>
    /// 验证微应用输出
    /// </summary>
    public class ValidateOpenPlatformMicroApplicationOutput
    {
        /// <summary>
        /// 是否验证通过
        /// </summary>
        public bool IsValidate { get; set; }
        /// <summary>
        /// 验证通过对象
        /// </summary>
        public OpenPlatformMicroApplicationDto OpenPlatformMicroApplication { get; set; }
    }
}
