
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 用户帐户表
    /// </summary>
    public partial class BaseUser
    {
        public int UserId { get; set; } //1
        public string UserCode { get; set; } //1
        public string UserAccount { get; set; } //1
        public byte[] UserPwd { get; set; } //1
        public string UserName { get; set; } //1
        public int UserSex { get; set; } //1
        public string Title { get; set; } //1
        public string Email { get; set; } //1
        public string Remark { get; set; } //1
        public Nullable<int> Status { get; set; } //1
        public int DeleteMark { get; set; } //1
        public System.DateTime CreateDate { get; set; } //1
        public System.DateTime ModifyDate { get; set; } //1
        public int CreateUserId { get; set; } //1
        public int ModifyUserId { get; set; } //1
    }
}
