using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeDu.BaseServiceOpenPlatform.OpenPlatformMicroApplication.Dtos
{
    /// <summary>
    /// 验证微应用输入参数
    /// </summary>
    public class ValidateOpenPlatformMicroApplicationInput
    {
        /// <summary>
        /// AppId
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// AppSecret
        /// </summary>
        public string AppSecret { get; set; }
    }
}
