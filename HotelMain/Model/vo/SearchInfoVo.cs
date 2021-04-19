using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMain.Model.vo
{
    public class SearchInfoVo
    {
        /// <summary>
        /// 流水号
        /// </summary>
        public string lsh { get; set; }
        /// <summary>
        /// 房间编号
        /// </summary>
        public string fjbh { get; set; }
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string khxm { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string lxdh { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string sfzhm { get; set; }
    }
}
