
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 登录日志
    /// </summary>
    public partial class BaseLoginLog
    {
        public int LogId { get; set; } //1
        public string LoginIp { get; set; } //1
        public string LoginUser { get; set; } //1
        public int LoginStatus { get; set; } //1
        public System.DateTime LoginDate { get; set; } //1
    }
}
