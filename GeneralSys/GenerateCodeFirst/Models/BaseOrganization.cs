
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 组织机构、部门表
    /// </summary>
    public partial class BaseOrganization
    {
        public int OrganizationId { get; set; } //1
        public string OrganizationCode { get; set; } //1
        public string OrganizationName { get; set; } //1
        public string OrganizationManager { get; set; } //1
        public string OrganizationTel { get; set; } //1
        public int ParentId { get; set; } //1
        public int SortCode { get; set; } //1
        public string Remark { get; set; } //1
        public int DeleteMark { get; set; } //1
        public System.DateTime CreateDate { get; set; } //1
        public System.DateTime ModifyDate { get; set; } //1
        public int CreateUserId { get; set; } //1
        public int ModifyUserId { get; set; } //1
    }
}
