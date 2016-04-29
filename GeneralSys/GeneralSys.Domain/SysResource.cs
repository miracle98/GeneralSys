using System;
using System.Collections.Generic;

namespace GeneralSys.Domain//GeneralSys.Repository.Models
{
    public partial class SysResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int ParentId { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime InsertTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}
