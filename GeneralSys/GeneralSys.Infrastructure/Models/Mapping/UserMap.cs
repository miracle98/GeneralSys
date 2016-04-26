using System.Data.Entity.ModelConfiguration;

namespace GeneralSys.Infrastructure.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Account)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.BizCode)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            ToTable("User");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Account).HasColumnName("Account");
            Property(t => t.Password).HasColumnName("Password");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Sex).HasColumnName("Sex");
            Property(t => t.Status).HasColumnName("Status");
            Property(t => t.Type).HasColumnName("Type");
            Property(t => t.BizCode).HasColumnName("BizCode");
            Property(t => t.CreateTime).HasColumnName("CreateTime");
            Property(t => t.CreateId).HasColumnName("CreateId");
        }
    }
}