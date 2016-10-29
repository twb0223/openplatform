using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using Abp.Domain.Entities;

namespace KeDu.BaseServiceOpenPlatform.Models
{

    [Table("OpenPlatformMicroApplication")]
    public partial class OpenPlatformMicroApplication : Entity<Guid>
    {
        public OpenPlatformMicroApplication()
        {
            MicroApplicationAuthorization = new HashSet<MicroApplicationAuthorization>();
            MicroApplicationVisibleRange = new HashSet<MicroApplicationVisibleRange>();
            OpenUserHeads = new HashSet<OpenUserHeads>();
        }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string logo { get; set; }

        [Required]
        [StringLength(500)]
        public string Introduction { get; set; }

        [Required]
        [StringLength(500)]
        public string AppUrl { get; set; }

        [Required]
        [StringLength(500)]
        public string BackUrl { get; set; }

        [Required]
        [StringLength(200)]
        public string AppId { get; set; }

        [Required]
        [StringLength(200)]
        public string AppSecret { get; set; }

        public int IsOpen { get; set; }

        public int IsExamine { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid CreatorId { get; set; }

        public DateTime? ExamineTime { get; set; }

        public Guid? ExamineUserId { get; set; }

        public virtual AdminUsers AdminUsers { get; set; }

        public virtual ICollection<MicroApplicationAuthorization> MicroApplicationAuthorization { get; set; }

        public virtual ICollection<MicroApplicationVisibleRange> MicroApplicationVisibleRange { get; set; }

        public virtual ICollection<OpenUserHeads> OpenUserHeads { get; set; }

        public virtual OpenPlatformUsers OpenPlatformUsers { get; set; }
    }
}
