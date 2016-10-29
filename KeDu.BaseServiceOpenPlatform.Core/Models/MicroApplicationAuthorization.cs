using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using Abp.Domain.Entities;

namespace KeDu.BaseServiceOpenPlatform.Models
{

    [Table("MicroApplicationAuthorization")]
    public partial class MicroApplicationAuthorization : Entity<Guid>
    {
        public DateTime CreateTime { get; set; }

        public Guid OpenPlatformMicroApplicationId { get; set; }

        public Guid CompanyId { get; set; }

        public int RangeType { get; set; }

        public Guid UserId { get; set; }

     
        public Guid? RangeId { get; set; }

        public virtual OpenPlatformMicroApplication OpenPlatformMicroApplication { get; set; }
    }
}
