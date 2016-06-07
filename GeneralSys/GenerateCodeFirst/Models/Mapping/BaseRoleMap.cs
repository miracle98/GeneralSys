using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;


namespace GeneralSys.Repository.Models.Mapping
{
    public class BaseRoleMap : EntityTypeConfiguration<BaseRole>
    {
        public BaseRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.RolesId);

            // Properties
            this.Property(t => t.RolesName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RoleRestriction)
                .HasMaxLength(50);


           }
    }
}
