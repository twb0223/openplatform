using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeDu.BaseServiceOpenPlatform.OpenPlatformMicroApplication.Dtos
{
    public class GetOpenPlatformMicroApplicationByConditionInput
    {
        /// <summary>
        /// 用户iD
        /// </summary>
        public Guid? UserID { get; set; }
        /// <summary>
        /// 公司ID
        /// </summary>
        public Guid? CompanyID { get; set; }
        /// <summary>
        /// 门店ID
        /// </summary>
        public Guid? ShopID { get;set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public Guid? DepartmentID { get; set; }
    }
}
