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

        public DbSet<SysResource> SysResources { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SysResourceMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
