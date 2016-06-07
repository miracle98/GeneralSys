using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;


namespace GeneralSys.Repository.Models.Mapping
{
    public class BaseUserRsResourceMap : EntityTypeConfiguration<BaseUserRsResource>
    {
        public BaseUserRsResourceMap()
        {
            // Primary Key
            this.HasKey(t => t.UserResourceId);

            // Properties
            this.Property(t => t.UserResourceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ResourceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


           }
    }
}
