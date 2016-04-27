using System.Data.Entity;
using GeneralSys.Domain;
using GeneralSys.Repository.Models.Mapping;

namespace GeneralSys.Repository.Models
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