
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public partial class User
    {
        public int Id { get; set; } //1
        public string Account { get; set; } //1
        public string Password { get; set; } //1
        public string Name { get; set; } //1
        public int Sex { get; set; } //1
        public int Status { get; set; } //1
        public int Type { get; set; } //1
        public string BizCode { get; set; } //1
        public System.DateTime CreateTime { get; set; } //1
        public int CreateId { get; set; } //1
    }
}
