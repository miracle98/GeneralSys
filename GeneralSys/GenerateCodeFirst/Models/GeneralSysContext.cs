using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using GeneralSys.Domain;
using GeneralSys.Repository.Models.Mapping;

namespace GeneralSys.Repository.Models
{
    public partial class GeneralSysContext : DbContext
    {
        static GeneralSysContext()
        {
            Database.SetInitializer<GeneralSysContext>(null);
        }

        public GeneralSysContext()
            : base("Name=GeneralSysContext")
        {
        }

        public DbSet<BaseLoginLog> BaseLoginLogs { get; set; }
        public DbSet<BaseOrganization> BaseOrganizations { get; set; }
        public DbSet<BaseResource> BaseResources { get; set; }
        public DbSet<BaseRole> BaseRoles { get; set; }
        public DbSet<BaseRolesRsResource> BaseRolesRsResources { get; set; }
        public DbSet<BaseStaffOrganize> BaseStaffOrganizes { get; set; }
        public DbSet<BaseUser> BaseUsers { get; set; }
        public DbSet<BaseUserGroup> BaseUserGroups { get; set; }
        public DbSet<BaseUserGroupRsResource> BaseUserGroupRsResources { get; set; }
        public DbSet<BaseUserRole> BaseUserRoles { get; set; }
        public DbSet<BaseUserRsResource> BaseUserRsResources { get; set; }
        public DbSet<BaseUserRsUserGroup> BaseUserRsUserGroups { get; set; }
        public DbSet<SysResource> SysResources { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BaseLoginLogMap());
            modelBuilder.Configurations.Add(new BaseOrganizationMap());
            modelBuilder.Configurations.Add(new BaseResourceMap());
            modelBuilder.Configurations.Add(new BaseRoleMap());
            modelBuilder.Configurations.Add(new BaseRolesRsResourceMap());
            modelBuilder.Configurations.Add(new BaseStaffOrganizeMap());
            modelBuilder.Configurations.Add(new BaseUserMap());
            modelBuilder.Configurations.Add(new BaseUserGroupMap());
            modelBuilder.Configurations.Add(new BaseUserGroupRsResourceMap());
            modelBuilder.Configurations.Add(new BaseUserRoleMap());
            modelBuilder.Configurations.Add(new BaseUserRsResourceMap());
            modelBuilder.Configurations.Add(new BaseUserRsUserGroupMap());
            modelBuilder.Configurations.Add(new SysResourceMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
