using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelMain.Model
{
    public class SysCode
    {
        /// <summary>
        /// 代码类别
        /// </summary>
        public string dmlb { get; set; }
        /// <summary>
        /// 代码值
        /// </summary>
        public string dmz { get; set; }
        /// <summary>
        /// 代码说明1
        /// </summary>
        public string dmsm1 { get; set; }
        /// <summary>
        /// 代码说明2
        /// </summary>
        public string dmsm2 { get; set; }
        /// <summary>
        /// 代码说明3
        /// </summary>
        public string dmsm3 { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string zt { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string bz { get; set; }
    }
}
