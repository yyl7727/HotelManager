using HotelMain.Dal;
using HotelMain.Model;
using HotelMain.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelMain.Bll
{
    public static class Bll_Admin
    {
        /// <summary>
        /// 检查用户名密码
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public static object CheckIdPwd(Admin admin)
        {
            admin.ygmm = Encryption.Md5(admin.ygmm);
            return Dal_Admin.CheckIdPwd(admin);
        }
    }
}
