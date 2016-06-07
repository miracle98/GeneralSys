
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 用户组管理
    /// </summary>
    public partial class BaseUserGroup
    {
        public int UserGroupId { get; set; } //1
        public int ParentId { get; set; } //1
        public string UserGroupCode { get; set; } //1
        public string UserGroupName { get; set; } //1
        public int SortCode { get; set; } //1
        public string Remark { get; set; } //1
        public int DeleteMark { get; set; } //1
        public System.DateTime CreateDate { get; set; } //1
        public System.DateTime ModifyDate { get; set; } //1
        public int CreateUserId { get; set; } //1
        public int ModifyUserId { get; set; } //1
    }
}
