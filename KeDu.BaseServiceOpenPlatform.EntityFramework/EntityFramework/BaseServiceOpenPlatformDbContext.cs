using System.Data.Entity;
using Abp.EntityFramework;
using KeDu.BaseServiceOpenPlatform.Models;

namespace KeDu.BaseServiceOpenPlatform.EntityFramework
{
    public class BaseServiceOpenPlatformDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<AdminUsers> AdminUsers { get; set; }
        public virtual IDbSet<MicroApplicationAuthorization> MicroApplicationAuthorization { get; set; }
        public virtual IDbSet<MicroApplicationVisibleRange> MicroApplicationVisibleRange { get; set; }
        public virtual IDbSet<OpenPlatformMicroApplication> OpenPlatformMicroApplication { get; set; }
        public virtual IDbSet<OpenPlatformUsers> OpenPlatformUsers { get; set; }
        public virtual IDbSet<OpenUserHeads> OpenUserHeads { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public BaseServiceOpenPlatformDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in BaseServiceOpenPlatformDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of BaseServiceOpenPlatformDbContext since ABP automatically handles it.
         */
        public BaseServiceOpenPlatformDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminUsers>()
                .HasMany(e => e.OpenPlatformMicroApplication)
                .WithRequired(e => e.AdminUsers)
                .HasForeignKey(e => e.ExamineUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminUsers>()
                .HasMany(e => e.MicroApplicationVisibleRange)
                .WithRequired(e => e.AdminUsers)
                .HasForeignKey(e => e.AdminUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OpenPlatformMicroApplication>()
                .HasMany(e => e.MicroApplicationAuthorization)
                .WithRequired(e => e.OpenPlatformMicroApplication)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OpenPlatformMicroApplication>()
                .HasMany(e => e.MicroApplicationVisibleRange)
                .WithRequired(e => e.OpenPlatformMicroApplication)
                .HasForeignKey(e => e.OpenPlatformMicroApplication_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OpenPlatformMicroApplication>()
                .HasMany(e => e.OpenUserHeads)
                .WithRequired(e => e.OpenPlatformMicroApplication)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OpenPlatformUsers>()
                .HasMany(e => e.OpenPlatformMicroApplication)
                .WithRequired(e => e.OpenPlatformUsers)
                .HasForeignKey(e => e.CreatorId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
