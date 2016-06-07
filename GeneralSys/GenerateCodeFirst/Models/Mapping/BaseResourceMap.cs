using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;


namespace GeneralSys.Repository.Models.Mapping
{
    public class BaseResourceMap : EntityTypeConfiguration<BaseResource>
    {
        public BaseResourceMap()
        {
            // Primary Key
            this.HasKey(t => t.ResourceId);

            // Properties
            this.Property(t => t.ResourceName)
                .HasMaxLength(50);

            this.Property(t => t.ResourceTitle)
                .HasMaxLength(50);

            this.Property(t => t.ResourceImg)
                .HasMaxLength(200);

            this.Property(t => t.ResourceUrl)
                .HasMaxLength(200);


           }
    }
}
