using HotelMain.Model;
using HotelMain.Tool;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HotelMain.Dal
{
    public static class Dal_Admin
    {
        /// <summary>
        /// 检查用户名密码
        /// </summary>
        /// <param name="admin">用户对象</param>
        /// <returns></returns>
        public static object CheckIdPwd(Admin admin)
        {
            MySqlParameter[] para = {
                                    new MySqlParameter("@ygxh",admin.ygxh),
                                    new MySqlParameter("@ygmm",admin.ygmm)
                                  };
            return SqlHelper.ExecuteScalar("Login", CommandType.StoredProcedure, para);
        }
    }
}
