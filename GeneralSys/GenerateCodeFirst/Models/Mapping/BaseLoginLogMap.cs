using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;


namespace GeneralSys.Repository.Models.Mapping
{
    public class BaseLoginLogMap : EntityTypeConfiguration<BaseLoginLog>
    {
        public BaseLoginLogMap()
        {
            // Primary Key
            this.HasKey(t => t.LogId);

            // Properties
            this.Property(t => t.LoginIp)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LoginUser)
                .IsRequired()
                .HasMaxLength(50);


           }
    }
}
