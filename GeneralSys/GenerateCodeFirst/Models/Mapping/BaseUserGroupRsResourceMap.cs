using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;


namespace GeneralSys.Repository.Models.Mapping
{
    public class BaseUserGroupRsResourceMap : EntityTypeConfiguration<BaseUserGroupRsResource>
    {
        public BaseUserGroupRsResourceMap()
        {
            // Primary Key
            this.HasKey(t => t.UserGroupResourceId);

            // Properties

           }
    }
}
