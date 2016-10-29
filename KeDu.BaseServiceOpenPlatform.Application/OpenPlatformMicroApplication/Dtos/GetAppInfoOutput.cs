using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeDu.BaseServiceOpenPlatform.OpenPlatformMicroApplication.Dtos
{
    public class GetAppInfoOutput
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string logo { get; set; }
        public string Introduction { get; set; }
        public string AppUrl { get; set; }
        public string BackUrl { get; set; }
        public string AppId { get; set; }
        public string AppSecret { get; set; }
        public int IsOpen { get; set; }
        public int IsExamine { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid CreatorId { get; set; }
        public string CreatorName { get; set; }
        public DateTime? ExamineTime { get; set; }
        public Guid? ExamineUserId { get; set; }
        public string ExamineUserName { get; set; }

    }
}
