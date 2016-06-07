
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public partial class BaseRole
    {
        public int RolesId { get; set; } //1
        public int ParentId { get; set; } //1
        public string RolesName { get; set; } //1
        public string RoleRestriction { get; set; } //1
        public int DeleteMark { get; set; } //1
        public System.DateTime CreateDate { get; set; } //1
        public System.DateTime ModifyDate { get; set; } //1
        public int CreateUserId { get; set; } //1
        public int ModifyUserId { get; set; } //1
    }
}
