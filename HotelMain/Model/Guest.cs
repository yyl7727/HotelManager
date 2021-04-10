using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMain.Model
{
    public class Guest
    {
        /// <summary>
        /// 流水号
        /// </summary>
        public string lsh { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string yhxm { get; set; }
        /// <summary>
        /// 用户性别
        /// </summary>
        public string yhxb { get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string sfzhm { get; set; }
    }
}
