using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using Abp.Domain.Entities;

namespace KeDu.BaseServiceOpenPlatform.Models
{

    [Table("MicroApplicationVisibleRange")]
    public partial class MicroApplicationVisibleRange : Entity<Guid>
    { 
        public Guid OpenPlatformMicroApplication_Id { get; set; }
          
        public Guid Company_Id { get; set; }
           
        public Guid AdminUserId { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual AdminUsers AdminUsers { get; set; }

        public virtual OpenPlatformMicroApplication OpenPlatformMicroApplication { get; set; }
    }
}
