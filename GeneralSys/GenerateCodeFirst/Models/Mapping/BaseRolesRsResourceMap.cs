using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;


namespace GeneralSys.Repository.Models.Mapping
{
    public class BaseRolesRsResourceMap : EntityTypeConfiguration<BaseRolesRsResource>
    {
        public BaseRolesRsResourceMap()
        {
            // Primary Key
            this.HasKey(t => t.RolesResourceId);

            // Properties
            this.Property(t => t.ResourceId)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);


           }
    }
}
