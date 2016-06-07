using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;


namespace GeneralSys.Repository.Models.Mapping
{
    public class BaseUserGroupMap : EntityTypeConfiguration<BaseUserGroup>
    {
        public BaseUserGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.UserGroupId);

            // Properties
            this.Property(t => t.UserGroupCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserGroupName)
                .IsRequired()
                .HasMaxLength(50);


           }
    }
}
