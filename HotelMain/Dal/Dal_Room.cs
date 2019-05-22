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
    public static class Dal_Room
    {
        /// <summary>
        /// 获取所有房间类型信息
        /// </summary>
        /// <returns></returns>
        public static List<SysCode> GetAllRoomType()
        {
            List<SysCode> roomType = new List<SysCode>();
            string sql = "select * from syscode where dmlb='1001'";
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, null);
            while (reader.Read())
            {
                SysCode r = new SysCode();
                r.dmz = reader["dmz"].ToString();
                r.dmsm1 = reader["dmsm1"].ToString();
                roomType.Add(r);
            }
            reader.Close();
            return roomType;
        }

        /// <summary>
        /// 查询所有房间状态
        /// </summary>
        /// <returns></returns>
        public static List<Room> GetRoomState()
        {
            List<Room> room = new List<Room>();
            string sql = "select * from Room";
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, null);
            while (reader.Read())
            {
                Room r = new Room();
                r.fjbh = reader["fjbh"].ToString();
                r.fjzt = reader["fjzt"].ToString();
                room.Add(r);
            }
            reader.Close();
            return room;
        }

        /// <summary>
        /// 根据房间类型查询房间状态
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static List<Room> GetRoomStateByType(string fjlx)
        {
            List<Room> room = new List<Room>();
            string sql = "select * from Room where fjlx=@fjlx";
            MySqlParameter[] para = {
                new MySqlParameter("@fjlx", fjlx)
            };
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, para);
            while (reader.Read())
            {
                Room r = new Room();
                r.fjbh = reader["fjbh"].ToString();
                r.fjzt = reader["fjzt"].ToString();
                room.Add(r);
            }
            reader.Close();
            return room;
        }

        /// <summary>
        /// 查询总房间数
        /// </summary>
        /// <returns></returns>
        public static object GetRoomCount(string fjlx)
        {
            MySqlParameter[] para = {
                new MySqlParameter("@fjlx", fjlx)
            };
            return SqlHelper.ExecuteScalar("Getroomcount", CommandType.StoredProcedure, para);
        }

        /// <summary>
        /// 根据状态ID和房间类型查询房间数
        /// </summary>
        /// <param name="stateId"></param>
        /// <returns></returns>
        public static object GetRoomStateCount(string fjzt, string fjlx)
        {
            MySqlParameter[] para = {
                new MySqlParameter("@fjzt", fjzt),
                new MySqlParameter("@fjlx",fjlx)
            };
            return SqlHelper.ExecuteScalar("GetRoomStateCount", CommandType.StoredProcedure, para);
        }
    }
}
