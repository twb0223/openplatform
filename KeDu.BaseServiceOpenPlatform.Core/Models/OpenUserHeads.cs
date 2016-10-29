using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using Abp.Domain.Entities;

namespace KeDu.BaseServiceOpenPlatform.Models
{

    public partial class OpenUserHeads : Entity<Guid>
    {
        [Required]
        [StringLength(200)]
        public string OpenId { get; set; }

        public Guid UserId { get; set; }

        public Guid OpenPlatformMicroApplicationId { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual OpenPlatformMicroApplication OpenPlatformMicroApplication { get; set; }
    }
}
