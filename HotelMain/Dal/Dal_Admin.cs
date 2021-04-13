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
            string sql = "select count(*) sl from Admin t where t.ygxh=@ygxh and t.ygmm=@ygmm";
            MySqlParameter[] para = {
                                    new MySqlParameter("@ygxh",admin.ygxh),
                                    new MySqlParameter("@ygmm",admin.ygmm)
                                  };
            return SqlHelper.ExecuteScalar(sql, CommandType.Text, para);
        }

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        public static List<Admin> GetAllUser()
        {
            List<Admin> lst_admin = new List<Admin>();
            string sql = "select * from Admin";
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, null);
            while (reader.Read())
            {
                Admin admin = new Admin();
                admin.ygxh = reader["ygxh"].ToString();
                admin.ygmm = reader["ygmm"].ToString();
                lst_admin.Add(admin);
            }
            reader.Close();
            return lst_admin;
        }
    }
}
