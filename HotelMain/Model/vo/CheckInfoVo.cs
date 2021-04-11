using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMain.Model.vo
{
    public class CheckInfoVo
    {
        /// <summary>
        /// 房间编号
        /// </summary>
        public string fjbh { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string yhxm { get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string sfzhm { get; set; }
        /// <summary>
        /// 入住日期
        /// </summary>
        public DateTime rzrq { get; set; }
    }
}
