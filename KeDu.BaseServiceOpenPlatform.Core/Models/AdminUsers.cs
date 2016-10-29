using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using Abp.Domain.Entities;

namespace KeDu.BaseServiceOpenPlatform.Models
{

    public partial class AdminUsers : Entity<Guid>
    {
        public AdminUsers()
        {
            OpenPlatformMicroApplication = new HashSet<OpenPlatformMicroApplication>();
            MicroApplicationVisibleRange = new HashSet<MicroApplicationVisibleRange>();
        }

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual ICollection<OpenPlatformMicroApplication> OpenPlatformMicroApplication { get; set; }

        public virtual ICollection<MicroApplicationVisibleRange> MicroApplicationVisibleRange { get; set; }
    }
}
