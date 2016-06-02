using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralSys.App.ViewModel
{
    public class ZTreeModel
    {
        /// <summary>
        /// 节点ID
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 节点名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 父ID
        /// </summary>
        public int pId { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string icon { get; set; }
        /// <summary>
        /// URL地址
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 图标样式
        /// </summary>
        public string iconSkin { get; set; }
    }
}
