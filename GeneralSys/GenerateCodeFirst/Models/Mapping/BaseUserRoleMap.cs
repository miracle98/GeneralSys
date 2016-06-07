using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;


namespace GeneralSys.Repository.Models.Mapping
{
    public class BaseUserRoleMap : EntityTypeConfiguration<BaseUserRole>
    {
        public BaseUserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.UserRoleId);

            // Properties

           }
    }
}
