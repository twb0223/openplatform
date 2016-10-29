using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeDu.BaseServiceOpenPlatform.MicroApplicationAuthorization.Dtos
{
    public class MicroApplicationAuthorizationDto : EntityDto<Guid>
    {
        public DateTime CreateTime { get; set; }

        public Guid OpenPlatformMicroApplicationId { get; set; }

        public Guid CompanyId { get; set; }

       // 范围类型（0:全公司,1:门店,2:部门,3:个人）
        public int RangeType { get; set; }

        public Guid UserId { get; set; }

        /// <summary>
        /// 类型ID
        /// </summary>
        public Guid? RangeId { get; set; }
    }
}
