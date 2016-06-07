
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 用户组菜单关系表
    /// </summary>
    public partial class BaseUserGroupRsResource
    {
        public int UserGroupResourceId { get; set; } //1
        public int UserGroupId { get; set; } //1
        public int ResourceId { get; set; } //1
        public System.DateTime CreateDate { get; set; } //1
        public int CreateUserId { get; set; } //1
    }
}
