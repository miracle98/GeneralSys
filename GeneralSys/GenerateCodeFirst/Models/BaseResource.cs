
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 模块（菜单）资源表
    /// </summary>
    public partial class BaseResource
    {
        public int ResourceId { get; set; } //1
        public Nullable<int> ParentId { get; set; } //1
        public string ResourceName { get; set; } //1
        public string ResourceTitle { get; set; } //1
        public string ResourceImg { get; set; } //1
        public Nullable<int> ResourceType { get; set; } //1
        public string ResourceUrl { get; set; } //1
        public Nullable<int> SortCode { get; set; } //1
        public int DeleteMark { get; set; } //1
        public System.DateTime CreateDate { get; set; } //1
        public System.DateTime ModifyDate { get; set; } //1
        public int CreateUserId { get; set; } //1
        public int ModifyUserId { get; set; } //1
    }
}
