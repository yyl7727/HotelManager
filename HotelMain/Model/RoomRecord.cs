using System;
using System.Collections.Generic;

namespace HotelMain.Model
{
    /// <summary>
    /// 入住记录实体
    /// </summary>
    public class RoomRecord
    {
        /// <summary>
        /// 流水号
        /// </summary>
        public string lsh { get; set; }
        /// <summary>
        /// 客户信息
        /// </summary>
        public List<Guest> khxx { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string lxdh { get; set; }
        /// <summary>
        /// 房间编号
        /// </summary>
        public string fjbh { get; set; }
        /// <summary>
        /// 入住状态
        /// </summary>
        public string rzzt { get; set; }
        /// <summary>
        /// 入住日期
        /// </summary>
        public DateTime rzrq { get; set; }
        /// <summary>
        /// 入住押金
        /// </summary>
        public string rzyj { get; set; }
        /// <summary>
        /// 入住单价
        /// </summary>
        public string rzdj { get; set; }
        /// <summary>
        /// 退房日期
        /// </summary>
        public DateTime tfrq { get; set; }
        /// <summary>
        /// 入住天数
        /// </summary>
        public string rzts { get; set; }
        /// <summary>
        /// 其他消费
        /// </summary>
        public string qtxf { get; set; }
    }
}
