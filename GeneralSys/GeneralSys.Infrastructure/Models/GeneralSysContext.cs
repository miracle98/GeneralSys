using System.Data.Entity;
using GeneralSys.Infrastructure.Models.Mapping;

namespace GeneralSys.Infrastructure.Models
{
    public class GeneralSysContext : DbContext
    {
        static GeneralSysContext()
        {
            Database.SetInitializer<GeneralSysContext>(null);
        }

        public GeneralSysContext()
            : base("Name=GeneralSysContext")
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}