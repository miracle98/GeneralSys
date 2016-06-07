
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 用户帐户表菜单关系表
    /// </summary>
    public partial class BaseUserRsResource
    {
        public int UserResourceId { get; set; } //1
        public int UserId { get; set; } //1
        public int ResourceId { get; set; } //1
        public System.DateTime CreateDate { get; set; } //1
        public int CreateUserId { get; set; } //1
    }
}
