
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 用户帐户用户组关系表
    /// </summary>
    public partial class BaseUserRsUserGroup
    {
        public int RsId { get; set; } //1
        public int UserId { get; set; } //1
        public int UserGroupId { get; set; } //1
        public System.DateTime CreateDate { get; set; } //1
        public System.DateTime ModifyDate { get; set; } //1
        public int CreateUserId { get; set; } //1
    }
}
