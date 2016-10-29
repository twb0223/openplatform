using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;


namespace KeDu.BaseServiceOpenPlatform.MicroApplicationVisibleRange.Dtos
{
    public class MicroApplicationVisibleRangeDto : EntityDto<Guid>
    {
        public Guid OpenPlatformMicroApplication_Id { get; set; }

        public Guid Company_Id { get; set; }

        public Guid AdminUserId { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
