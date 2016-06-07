
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 用户组织关系表
    /// </summary>
    public partial class BaseStaffOrganize
    {
        public int StaffOrganizeId { get; set; } //1
        public int OrganizationId { get; set; } //1
        public int UserId { get; set; } //1
        public int CreateUserId { get; set; } //1
        public System.DateTime CreateDate { get; set; } //1
        public System.DateTime ModifyDate { get; set; } //1
    }
}
