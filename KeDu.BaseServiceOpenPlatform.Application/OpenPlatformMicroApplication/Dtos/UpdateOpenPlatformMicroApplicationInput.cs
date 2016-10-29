using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeDu.BaseServiceOpenPlatform.OpenPlatformMicroApplication.Dtos
{
    public class UpdateOpenPlatformMicroApplicationInput
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        /// <summary>
        /// logo
        /// </summary>
        public string logo { get; set; }
        /// <summary>
        /// 介绍
        /// </summary>
        public string Introduction { get; set; }


        public string AppUrl { get; set; }

        public string BackUrl { get; set; }
    }
}
