using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using Abp.Domain.Entities;

namespace KeDu.BaseServiceOpenPlatform.Models
{

    public partial class OpenPlatformUsers : Entity<Guid>
    {
        public OpenPlatformUsers()
        {
            OpenPlatformMicroApplication = new HashSet<OpenPlatformMicroApplication>();
        }

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Mobile { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual ICollection<OpenPlatformMicroApplication> OpenPlatformMicroApplication { get; set; }
    }
}
