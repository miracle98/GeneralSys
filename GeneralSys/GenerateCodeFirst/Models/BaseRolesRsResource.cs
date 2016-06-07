
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 系统角色菜单关系表
    /// </summary>
    public partial class BaseRolesRsResource
    {
        public int RolesResourceId { get; set; } //1
        public int RolesId { get; set; } //1
        public string ResourceId { get; set; } //1
        public System.DateTime CreateDate { get; set; } //1
        public int CreateUserId { get; set; } //1
    }
}
