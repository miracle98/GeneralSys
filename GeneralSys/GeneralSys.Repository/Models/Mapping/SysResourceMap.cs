using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;

namespace GeneralSys.Repository.Models.Mapping
{
    public class SysResourceMap : EntityTypeConfiguration<SysResource>
    {
        public SysResourceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Url)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            this.Property(t => t.Icon)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("SysResource");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Icon).HasColumnName("Icon");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.InsertTime).HasColumnName("InsertTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
