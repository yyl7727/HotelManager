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

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        public static List<Admin> GetAllUser()
        {
            return Dal_Admin.GetAllUser();
        }
    }
}
