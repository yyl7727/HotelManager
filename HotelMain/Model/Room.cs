using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelMain.Model
{
    public class Room
    {
        /// <summary>
        /// 房间编号
        /// </summary>
        public string fjbh { get; set; }
        /// <summary>
        /// 房间类型
        /// </summary>
        public string fjlx { get; set; }
        /// <summary>
        /// 房间状态
        /// </summary>
        public string fjzt { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string bz { get; set; }
    }
}
