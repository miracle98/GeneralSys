using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;


namespace GeneralSys.Repository.Models.Mapping
{
    public class BaseUserRsUserGroupMap : EntityTypeConfiguration<BaseUserRsUserGroup>
    {
        public BaseUserRsUserGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.RsId);

            // Properties

           }
    }
}
