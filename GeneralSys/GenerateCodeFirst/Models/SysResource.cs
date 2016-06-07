
using System;
using System.Collections.Generic;

namespace GeneralSys.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SysResource
    {
        public int Id { get; set; } //1
        public string Name { get; set; } //1
        public string Url { get; set; } //1
        public string Description { get; set; } //1
        public string Icon { get; set; } //1
        public int ParentId { get; set; } //1
        public Nullable<int> Type { get; set; } //1
        public bool IsActive { get; set; } //1
        public System.DateTime InsertTime { get; set; } //1
        public System.DateTime UpdateTime { get; set; } //1
    }
}
