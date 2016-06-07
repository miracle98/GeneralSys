using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;


namespace GeneralSys.Repository.Models.Mapping
{
    public class BaseUserMap : EntityTypeConfiguration<BaseUser>
    {
        public BaseUserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserAccount)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserPwd)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.UserName)
                .HasMaxLength(30);

            this.Property(t => t.Title)
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .HasMaxLength(100);


           }
    }
}
