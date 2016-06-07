using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;


namespace GeneralSys.Repository.Models.Mapping
{
    public class BaseOrganizationMap : EntityTypeConfiguration<BaseOrganization>
    {
        public BaseOrganizationMap()
        {
            // Primary Key
            this.HasKey(t => t.OrganizationId);

            // Properties
            this.Property(t => t.OrganizationCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OrganizationName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OrganizationManager)
                .HasMaxLength(30);

            this.Property(t => t.OrganizationTel)
                .HasMaxLength(50);


           }
    }
}
