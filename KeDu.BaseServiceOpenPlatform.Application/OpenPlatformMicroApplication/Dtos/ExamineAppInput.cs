using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeDu.BaseServiceOpenPlatform.OpenPlatformMicroApplication.Dtos
{
    public class ExamineAppInput
    {
        public string AppId { get; set; }

        public Guid ExamineUserId { get; set; }

        public DateTime? ExamineTime { get; set; }

        /// <summary>
        /// 0=通过  1=未通过 默认未通过
        /// </summary>
        public int IsExamine { get; set; }
    }
}
