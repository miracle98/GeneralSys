using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GeneralSys.Domain;


namespace GeneralSys.Repository.Models.Mapping
{
    public class BaseStaffOrganizeMap : EntityTypeConfiguration<BaseStaffOrganize>
    {
        public BaseStaffOrganizeMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffOrganizeId);

            // Properties

           }
    }
}
