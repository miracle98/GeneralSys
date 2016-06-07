
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 用户帐户角色关系表
    /// </summary>
    public partial class BaseUserRole
    {
        public int UserRoleId { get; set; } //1
        public int UserId { get; set; } //1
        public int RolesId { get; set; } //1
        public System.DateTime CreateDate { get; set; } //1
        public System.DateTime ModifyDate { get; set; } //1
        public int CreateUserId { get; set; } //1
    }
}
